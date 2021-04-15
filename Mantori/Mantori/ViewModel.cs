using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mantori
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            Button_Click_Find = new RelayCommand(Button_Click_Find_CommandAction);
            Button_Click_Convert = new RelayCommand(Button_Click_Convert_CommandAction);

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        private string Find_Pathvalue = "경로를 입력해주세요";   //경로 텍스트박스 초기값
        public string Find_Path { get { return Find_Pathvalue; } set { Find_Pathvalue = value; OnPropertyChanged("Find_Path"); } }

        public RelayCommand Button_Click_Find { get; set; }
        private void Button_Click_Find_CommandAction(object par)    //파일찾기 버튼 클릭 시
        {
            Find_Path = Find_Header();
        }
        public RelayCommand Button_Click_Convert { get; set; }  //변환 버튼 클릭 시
        private void Button_Click_Convert_CommandAction(object par)
        {
            bool result = MakeIDL(Find_Path, Result_FileName());
            if (result)
            {
                MessageBox.Show("변환하였습니다.");
            }
            else
            {
                MessageBox.Show("변환에 실패하였습니다.");
            }
        }

        public string Find_Header() //경로 찾는 함수
        {
            OpenFileDialog h_file = new OpenFileDialog();

            bool? result = h_file.ShowDialog();

            if (result == true) return h_file.FileName;
            else return string.Empty;
        }

        public string Result_FileName()
        {
            string Result_path = null;
            string [] word = Find_Path.Split('.');

            int Word_Length = word.Length;

            if (Word_Length < 2)
            {
                return Result_path;
            }

            for (int i = 0; i < Word_Length-1; i++)
            {
                Result_path += word[i];
                Result_path += '.';
            }
            Result_path += "idl";
            return Result_path;
        }

        public bool MakeIDL(string loadText, string saveText)   //idl 파일 만들어주는 함수
        {
            char sp = ' ';  //스페이스바 선언
            char ub = '_';  //언더바 선언

            try
            {
                using (StreamReader S_Reader = new StreamReader(new FileStream(loadText, FileMode.Open, FileAccess.Read)))  //파일읽어오기
                {
                    using (StreamWriter S_Writer = new StreamWriter(new FileStream(saveText, FileMode.Create)))     //idl파일 만들어서 쓰기
                    {
                        while (true)
                        {
                            string Parse_F_line = S_Reader.ReadLine();  //첫줄이 class 인지 확인

                            if (Parse_F_line == null)
                            {
                                break;
                            }
                            string F_word = Parse_F_line.Split(sp)[0];

                            if (F_word == "class")
                            {
                                string Parse_S_line = S_Reader.ReadLine();  //두번째 줄이 "{" 인지 확인
                                if (Parse_S_line == "{")
                                {
                                    Parse_F_line = Parse_F_line.Replace("class", "struct");    //class -> struct로 교체
                                    S_Writer.WriteLine(Parse_F_line);
                                    S_Writer.WriteLine(Parse_S_line);

                                    string Parse_line = S_Reader.ReadLine();    //클래스 내부 라인 한줄씩 읽기

                                    int count = 0;

                                    while (Parse_line[0] != '}')
                                    {
                                        string word = Parse_line.Split(sp)[0];
                                        if (word == "#ifdef")
                                            count++;
                                        if (word == "#ifndef")
                                            count++;
                                        if (word == "#endif")
                                            count--;


                                        if (count == 0 && word != "public:" && word != "#endif")    //클래스 내부 변수만 찾아서 자르는 작업
                                        {

                                            for (int i = 0; ; i++)
                                            {
                                                if (!string.IsNullOrWhiteSpace(Parse_line.Split(sp)[i]))
                                                {
                                                    F_word = Parse_line.Split(sp)[i];   //변수타입 알아내기
                                                    break;
                                                }
                                            }

                                            if (F_word != F_word.ToUpper() && Parse_line.Split(ub)[0] == "    DDS")
                                            {
                                                Parse_line = "    " + Parse_line.Substring(8);
                                                int word_count; //변수타입이 몇번 째 자른 문자열에 저장되는지 확인
                                                for (word_count = 0; ; word_count++)
                                                {
                                                    if (!string.IsNullOrWhiteSpace(Parse_line.Split(sp)[word_count]))
                                                    {
                                                        F_word = Parse_line.Split(sp)[word_count];   //변수타입 알아내기
                                                        break;
                                                    }
                                                }
                                                char[] test = new char[100];

                                                int j = 0;
                                                test[j] = F_word[0];
                                                j++;

                                                for (int i = 1; i < F_word.Length; i++)
                                                {
                                                    if ('A' <= F_word[i] && F_word[i] <= 'Z')
                                                    {
                                                        test[j] = ' ';
                                                        j++;
                                                    }
                                                    test[j] = F_word[i];
                                                    j++;
                                                }
                                                string C_word = null;
                                                for (int i = 0; test[i] != '\0'; i++)
                                                {
                                                    C_word += test[i];
                                                }
                                                C_word = C_word.ToLower();
                                                Parse_line = Parse_line.Replace(Parse_line.Split(sp)[word_count], C_word);  //변수타입 바꿔주기
                                            }
                                            S_Writer.WriteLine(Parse_line);
                                        }
                                        Parse_line = S_Reader.ReadLine();
                                        while (string.IsNullOrWhiteSpace(Parse_line))
                                        {
                                            Parse_line = S_Reader.ReadLine();
                                        }
                                    }
                                    S_Writer.WriteLine(Parse_line);
                                }
                            }
                        }
                    }
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }

    }
}
