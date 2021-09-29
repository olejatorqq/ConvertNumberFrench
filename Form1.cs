﻿using System;
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

        //Сотни
        public List<String> hundreds = new List<string>();

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

            //20-100

            dozens.Add("vingt"); // 20
            dozens.Add("vingt-et-un"); // 21
            dozens.Add("trente"); //30
            dozens.Add("trente-et-un"); //31
            dozens.Add("quarante"); //40
            dozens.Add("quarante-et-un"); //41
            dozens.Add("cinquantre"); // 50
            dozens.Add("cinquantre-et-un"); //51
            dozens.Add("soixante"); // 60
            dozens.Add("soixante-et-un"); // 61
            dozens.Add("soixante-dix"); // 70
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
    }
}