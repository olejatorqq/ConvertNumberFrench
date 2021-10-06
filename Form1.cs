using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertNumberFrench
{
    public partial class Form1 : Form
    {
        //Еденицы
        public List<String> units = new List<string>();

        //Десятки
        public List<String> dozens = new List<string>();

        //11-19
        public List<String> elenine = new List<string>();

        //Десятки c 1
        public List<String> dozensune = new List<string>();
        
        //Сотни
        public List<String> hundreds = new List<string>();

        //Тысячи
        public List<String> thousands = new List<string>();
        
        //Ошибки
        public List<String> errors = new List<string>();

        public Form1()
        {
            InitializeComponent();

            //0 - 19

            units.Add("zero"); // 0
            units.Add("une"); // 1
            units.Add("deux"); // 2
            units.Add("trois"); // 3
            units.Add("quatre"); // 4
            units.Add("cinq"); // 5
            units.Add("six"); // 6
            units.Add("sept"); // 7
            units.Add("huit"); // 8
            units.Add("neuf"); // 9
            units.Add("dix"); // 10
            units.Add("onze"); // 11
            units.Add("douze"); // 12
            units.Add("treize"); // 13
            units.Add("quatorze"); // 14
            units.Add("quinze"); // 15
            units.Add("seize"); // 16
            units.Add("dix-sept"); // 17
            units.Add("dix-huit"); // 18
            units.Add("dix-neuf"); // 19

            //20-99
            
            dozens.Add("vingt"); // 20
            dozens.Add("trente"); //30         
            dozens.Add("quarante"); //40
            dozens.Add("cinquante"); // 50
            dozens.Add("soixante"); // 60
            dozens.Add("soixante-dix"); // 70
            dozens.Add("quatre-vingts"); // 80
            dozens.Add("quatre-vingt-dix"); // 90


            //dozensune.Add("vingt-et-un"); // 21
            //dozensune.Add("trente-et-un"); //31
            //dozensune.Add("quarante-et-un"); //41
            //dozensune.Add("cinquantre-et-un"); //51
            //dozensune.Add("soixante-et-un"); // 61
            //dozensune.Add("soixante et onze"); // 71
            //dozensune.Add("quatre-vingt-un"); // 81
            //dozensune.Add("quatre-vingt-onze"); // 91

            //100 - 1000

            hundreds.Add("cent"); //100


        }

        private void ToRussian(int i)
        {
            StringBuilder sb = new StringBuilder();
            while (i > 0)
            {
                Console.Out.WriteLine(i);
                if (i >= 500)
                {
                    i -= 500;
                    sb.Append("Ф");
                    continue;
                }
                if ( i >= 100)
                {
                    i -= 100;
                    sb.Append("Р");
                    continue;
                }
                if (i >= 30)
                {
                    i -= 30;
                    sb.Append("Л");
                    continue;
                }
                if (i >= 8)
                {
                    i -= 8;
                    sb.Append("И");
                    continue;
                }
                if (i >= 2)
                {
                    i -= 2;
                    sb.Append("В");
                    continue;
                }
                if ( i>= 1)
                {
                    i -= 1;
                    sb.Append("А");
                    continue;
                }
            }
            this.textBoxRus.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFrench_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            
            this.textBoxArab.Text = "";
            this.textBoxRus.Text = "";
            this.textBoxErrors.Text = "";
            bool ErrorCheck = false;
            int number = 0;
            String[] parts = this.textBoxFrench.Text.Split(new char[] { ' ', '-' },
                StringSplitOptions.RemoveEmptyEntries).Select(s => s.ToLowerInvariant()).ToArray();
            int[] num_array = new int[parts.Length];
            int i = 0;
            for(i = 0; i < parts.Length; i++)
            {


                if (units.Contains(parts[i])){
                    num_array[i] = units.IndexOf(parts[i]);
                    if (num_array[i] == 0 && parts.Length > 1)
                    {
                        this.textBoxErrors.Text = "Zero не может использоваться совместно с другими символами";
                        ErrorCheck = true;
                        break;
                    }
                    //if (i == 0 && parts[i + 1] != "cent")
                    //{
                    //    this.textBoxErrors.Text = "После слова " +parts[i] +" не может идти слово " + parts[i+1];
                    //    ErrorCheck = true;
                    //    break;
                    //}
                    if (i > 0)
                    {
                        if (num_array[i - 1] > 0 && num_array[i - 1] < 19)
                        {
                            this.textBoxErrors.Text = "Слова " + parts[i - 1] + " и " + parts[i] + " имеют одинаковый разряд";
                            ErrorCheck = true;
                            break;
                        }

                        
                        
                    }

                    number += units.IndexOf(parts[i]);
                }
                else
                {
                    //if (dozensune.Contains(parts[i]))
                    //{
                    //    number += (dozensune.IndexOf(parts[i]) + 2) * 10 + 1;
                    //    num_array[i] = (dozensune.IndexOf(parts[i]) + 2) * 10 + 1;
                    //    if (i < parts.Length - 1)
                    //    {
                    //        this.textBoxErrors.Text = "После " + parts[i] + " не должно ничего стоять ";
                    //        ErrorCheck = true;
                    //        break;
                    //    }
                    //    if (i > 1)
                    //    {
                    //        if (dozens.Contains(parts[i - 1]))
                    //        {
                    //            this.textBoxErrors.Text = "Slova " + parts[i - 1] + " и " + parts[i] + " имеют одинаковый разряд";
                    //            ErrorCheck = true;
                    //            break;
                    //        }
                    //    }    
                    //}
                    if (dozens.Contains(parts[i]) && dozens.IndexOf(parts[i]) < 5)
                    {

                        if (parts.Length > 1)
                        {
                            if (units.IndexOf(parts[i + 1]) > 9) // СЮДА ЗАХОДИТ 70 + 
                            {
                                MessageBox.Show("Сюда не надо заходить");
                                this.textBoxErrors.Text = "Использование несуществующего слова";
                                ErrorCheck = true;
                                break;
                                }
                            }
                            
                        if (parts.Length > 2)
                        {
                            if (parts[i + 1].Contains("et") && parts[i + 2].Contains("un"))
                            {
                                number += (dozens.IndexOf(parts[i]) + 2) * 10 + 1;
                                num_array[i] = (dozens.IndexOf(parts[i]) + 2) * 10 + 1;
                            }
                        }
                        else
                        {
                            number += (dozens.IndexOf(parts[i]) + 2) * 10;
                            num_array[i] = (dozens.IndexOf(parts[i]) + 2) * 10;
                         }   
                    }

                    if (dozens.Contains(parts[i]) && (dozens.IndexOf(parts[i]) > 5 && dozens.IndexOf(parts[i]) < 8))
                    {
                      
                    }
                }



                if (!ErrorCheck)
                {
                    this.textBoxArab.Text = number.ToString();
                    this.ToRussian(number);
                }
                if (ErrorCheck)
                {
                    this.textBoxArab.Clear();
                    this.textBoxRus.Clear();
                    this.textBoxErrors.Visible = true;
                }
                
            }
        }
    }
}
