using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace _40kDamageCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        static string myConnectionString = (@"Data Source=WIN-0CAASKGHV58; Initial Catalog=RetardServer; User id =testName; password=testWord;");
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moveBox = new System.Windows.Forms.TextBox();
            this.WSBox = new System.Windows.Forms.TextBox();
            this.BSBox = new System.Windows.Forms.TextBox();
            this.strBox = new System.Windows.Forms.TextBox();
            this.toughBox = new System.Windows.Forms.TextBox();
            this.woundBox = new System.Windows.Forms.TextBox();
            this.attackBox = new System.Windows.Forms.TextBox();
            this.saveBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gunS = new System.Windows.Forms.TextBox();
            this.gunRend = new System.Windows.Forms.TextBox();
            this.gunShot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.meleeS = new System.Windows.Forms.TextBox();
            this.meleeRend = new System.Windows.Forms.TextBox();
            this.meleeMult = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.meleeMult2 = new System.Windows.Forms.TextBox();
            this.meleeRend2 = new System.Windows.Forms.TextBox();
            this.meleeS2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.gunShot2 = new System.Windows.Forms.TextBox();
            this.gunRend2 = new System.Windows.Forms.TextBox();
            this.gunS2 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.saveBox2 = new System.Windows.Forms.TextBox();
            this.attackBox2 = new System.Windows.Forms.TextBox();
            this.woundBox2 = new System.Windows.Forms.TextBox();
            this.toughBox2 = new System.Windows.Forms.TextBox();
            this.strBox2 = new System.Windows.Forms.TextBox();
            this.BSBox2 = new System.Windows.Forms.TextBox();
            this.WSBox2 = new System.Windows.Forms.TextBox();
            this.moveBox2 = new System.Windows.Forms.TextBox();
            this.calculateDamageButton = new System.Windows.Forms.Button();
            this.woundCaused = new System.Windows.Forms.TextBox();
            this.woundsTaken = new System.Windows.Forms.TextBox();
            this.pointBox = new System.Windows.Forms.TextBox();
            this.pointBox2 = new System.Windows.Forms.TextBox();
            this.gunDamage = new System.Windows.Forms.TextBox();
            this.gunRange = new System.Windows.Forms.TextBox();
            this.meleeDamage = new System.Windows.Forms.TextBox();
            this.gunDamage2 = new System.Windows.Forms.TextBox();
            this.gunRange2 = new System.Windows.Forms.TextBox();
            this.meleeDamage2 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.Model1LoadList = new System.Windows.Forms.ListBox();
            this.label46 = new System.Windows.Forms.Label();
            this.SaveModel2 = new System.Windows.Forms.Button();
            this.LoadModel2 = new System.Windows.Forms.Button();
            this.saveModel1 = new System.Windows.Forms.Button();
            this.loadModel1 = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameBox2 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moveBox
            // 
            this.moveBox.Location = new System.Drawing.Point(131, 64);
            this.moveBox.Name = "moveBox";
            this.moveBox.Size = new System.Drawing.Size(31, 20);
            this.moveBox.TabIndex = 0;
            // 
            // WSBox
            // 
            this.WSBox.Location = new System.Drawing.Point(181, 64);
            this.WSBox.Name = "WSBox";
            this.WSBox.Size = new System.Drawing.Size(31, 20);
            this.WSBox.TabIndex = 1;
            // 
            // BSBox
            // 
            this.BSBox.Location = new System.Drawing.Point(238, 64);
            this.BSBox.Name = "BSBox";
            this.BSBox.Size = new System.Drawing.Size(31, 20);
            this.BSBox.TabIndex = 2;
            // 
            // strBox
            // 
            this.strBox.Location = new System.Drawing.Point(290, 64);
            this.strBox.Name = "strBox";
            this.strBox.Size = new System.Drawing.Size(31, 20);
            this.strBox.TabIndex = 3;
            // 
            // toughBox
            // 
            this.toughBox.Location = new System.Drawing.Point(339, 64);
            this.toughBox.Name = "toughBox";
            this.toughBox.Size = new System.Drawing.Size(31, 20);
            this.toughBox.TabIndex = 4;
            // 
            // woundBox
            // 
            this.woundBox.Location = new System.Drawing.Point(387, 64);
            this.woundBox.Name = "woundBox";
            this.woundBox.Size = new System.Drawing.Size(31, 20);
            this.woundBox.TabIndex = 5;
            // 
            // attackBox
            // 
            this.attackBox.Location = new System.Drawing.Point(434, 64);
            this.attackBox.Name = "attackBox";
            this.attackBox.Size = new System.Drawing.Size(31, 20);
            this.attackBox.TabIndex = 6;
            // 
            // saveBox
            // 
            this.saveBox.Location = new System.Drawing.Point(482, 64);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(31, 20);
            this.saveBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Move";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "WS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "BS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "T";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "W";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sv";
            // 
            // gunS
            // 
            this.gunS.Location = new System.Drawing.Point(181, 102);
            this.gunS.Name = "gunS";
            this.gunS.Size = new System.Drawing.Size(31, 20);
            this.gunS.TabIndex = 17;
            // 
            // gunRend
            // 
            this.gunRend.Location = new System.Drawing.Point(238, 102);
            this.gunRend.Name = "gunRend";
            this.gunRend.Size = new System.Drawing.Size(31, 20);
            this.gunRend.TabIndex = 18;
            // 
            // gunShot
            // 
            this.gunShot.Location = new System.Drawing.Point(290, 102);
            this.gunShot.Name = "gunShot";
            this.gunShot.Size = new System.Drawing.Size(31, 20);
            this.gunShot.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Gun";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "S";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Rend";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Shots";
            // 
            // meleeS
            // 
            this.meleeS.Location = new System.Drawing.Point(181, 141);
            this.meleeS.Name = "meleeS";
            this.meleeS.Size = new System.Drawing.Size(31, 20);
            this.meleeS.TabIndex = 24;
            // 
            // meleeRend
            // 
            this.meleeRend.Location = new System.Drawing.Point(238, 141);
            this.meleeRend.Name = "meleeRend";
            this.meleeRend.Size = new System.Drawing.Size(31, 20);
            this.meleeRend.TabIndex = 25;
            // 
            // meleeMult
            // 
            this.meleeMult.Location = new System.Drawing.Point(290, 141);
            this.meleeMult.Name = "meleeMult";
            this.meleeMult.Size = new System.Drawing.Size(31, 20);
            this.meleeMult.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(137, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Melee";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(178, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "S";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(235, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Rend";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(287, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Mult";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(287, 333);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Mult";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(235, 333);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 60;
            this.label19.Text = "Rend";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(178, 333);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 59;
            this.label20.Text = "S";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(137, 356);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "Melee";
            // 
            // meleeMult2
            // 
            this.meleeMult2.Location = new System.Drawing.Point(290, 349);
            this.meleeMult2.Name = "meleeMult2";
            this.meleeMult2.Size = new System.Drawing.Size(31, 20);
            this.meleeMult2.TabIndex = 57;
            // 
            // meleeRend2
            // 
            this.meleeRend2.Location = new System.Drawing.Point(238, 349);
            this.meleeRend2.Name = "meleeRend2";
            this.meleeRend2.Size = new System.Drawing.Size(31, 20);
            this.meleeRend2.TabIndex = 56;
            // 
            // meleeS2
            // 
            this.meleeS2.Location = new System.Drawing.Point(181, 349);
            this.meleeS2.Name = "meleeS2";
            this.meleeS2.Size = new System.Drawing.Size(31, 20);
            this.meleeS2.TabIndex = 55;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(287, 295);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 54;
            this.label22.Text = "Shots";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(235, 295);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 53;
            this.label23.Text = "Rend";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(178, 294);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "S";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(137, 313);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 13);
            this.label25.TabIndex = 51;
            this.label25.Text = "Gun";
            // 
            // gunShot2
            // 
            this.gunShot2.Location = new System.Drawing.Point(290, 310);
            this.gunShot2.Name = "gunShot2";
            this.gunShot2.Size = new System.Drawing.Size(31, 20);
            this.gunShot2.TabIndex = 50;
            // 
            // gunRend2
            // 
            this.gunRend2.Location = new System.Drawing.Point(238, 310);
            this.gunRend2.Name = "gunRend2";
            this.gunRend2.Size = new System.Drawing.Size(31, 20);
            this.gunRend2.TabIndex = 49;
            // 
            // gunS2
            // 
            this.gunS2.Location = new System.Drawing.Point(181, 310);
            this.gunS2.Name = "gunS2";
            this.gunS2.Size = new System.Drawing.Size(31, 20);
            this.gunS2.TabIndex = 48;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(479, 256);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 13);
            this.label27.TabIndex = 46;
            this.label27.Text = "Sv";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(431, 256);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 45;
            this.label28.Text = "A";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(384, 256);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 13);
            this.label29.TabIndex = 44;
            this.label29.Text = "W";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(336, 256);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 13);
            this.label30.TabIndex = 43;
            this.label30.Text = "T";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(287, 256);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(14, 13);
            this.label31.TabIndex = 42;
            this.label31.Text = "S";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(235, 256);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(21, 13);
            this.label32.TabIndex = 41;
            this.label32.Text = "BS";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(178, 256);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(25, 13);
            this.label33.TabIndex = 40;
            this.label33.Text = "WS";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(128, 256);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(34, 13);
            this.label34.TabIndex = 39;
            this.label34.Text = "Move";
            // 
            // saveBox2
            // 
            this.saveBox2.Location = new System.Drawing.Point(482, 272);
            this.saveBox2.Name = "saveBox2";
            this.saveBox2.Size = new System.Drawing.Size(31, 20);
            this.saveBox2.TabIndex = 38;
            // 
            // attackBox2
            // 
            this.attackBox2.Location = new System.Drawing.Point(434, 272);
            this.attackBox2.Name = "attackBox2";
            this.attackBox2.Size = new System.Drawing.Size(31, 20);
            this.attackBox2.TabIndex = 37;
            // 
            // woundBox2
            // 
            this.woundBox2.Location = new System.Drawing.Point(387, 272);
            this.woundBox2.Name = "woundBox2";
            this.woundBox2.Size = new System.Drawing.Size(31, 20);
            this.woundBox2.TabIndex = 36;
            // 
            // toughBox2
            // 
            this.toughBox2.Location = new System.Drawing.Point(339, 272);
            this.toughBox2.Name = "toughBox2";
            this.toughBox2.Size = new System.Drawing.Size(31, 20);
            this.toughBox2.TabIndex = 35;
            // 
            // strBox2
            // 
            this.strBox2.Location = new System.Drawing.Point(290, 272);
            this.strBox2.Name = "strBox2";
            this.strBox2.Size = new System.Drawing.Size(31, 20);
            this.strBox2.TabIndex = 34;
            // 
            // BSBox2
            // 
            this.BSBox2.Location = new System.Drawing.Point(238, 272);
            this.BSBox2.Name = "BSBox2";
            this.BSBox2.Size = new System.Drawing.Size(31, 20);
            this.BSBox2.TabIndex = 33;
            // 
            // WSBox2
            // 
            this.WSBox2.Location = new System.Drawing.Point(181, 272);
            this.WSBox2.Name = "WSBox2";
            this.WSBox2.Size = new System.Drawing.Size(31, 20);
            this.WSBox2.TabIndex = 32;
            // 
            // moveBox2
            // 
            this.moveBox2.Location = new System.Drawing.Point(131, 272);
            this.moveBox2.Name = "moveBox2";
            this.moveBox2.Size = new System.Drawing.Size(31, 20);
            this.moveBox2.TabIndex = 31;
            // 
            // calculateDamageButton
            // 
            this.calculateDamageButton.Location = new System.Drawing.Point(494, 105);
            this.calculateDamageButton.Name = "calculateDamageButton";
            this.calculateDamageButton.Size = new System.Drawing.Size(138, 23);
            this.calculateDamageButton.TabIndex = 62;
            this.calculateDamageButton.Text = "Calculate AVG Damage";
            this.calculateDamageButton.UseVisualStyleBackColor = true;
            this.calculateDamageButton.Click += new System.EventHandler(this.calculateDamageButton_Click);
            // 
            // woundCaused
            // 
            this.woundCaused.Location = new System.Drawing.Point(643, 53);
            this.woundCaused.Name = "woundCaused";
            this.woundCaused.Size = new System.Drawing.Size(37, 20);
            this.woundCaused.TabIndex = 63;
            // 
            // woundsTaken
            // 
            this.woundsTaken.Location = new System.Drawing.Point(643, 87);
            this.woundsTaken.Name = "woundsTaken";
            this.woundsTaken.Size = new System.Drawing.Size(37, 20);
            this.woundsTaken.TabIndex = 64;
            // 
            // pointBox
            // 
            this.pointBox.Location = new System.Drawing.Point(519, 64);
            this.pointBox.Name = "pointBox";
            this.pointBox.Size = new System.Drawing.Size(34, 20);
            this.pointBox.TabIndex = 65;
            // 
            // pointBox2
            // 
            this.pointBox2.Location = new System.Drawing.Point(519, 272);
            this.pointBox2.Name = "pointBox2";
            this.pointBox2.Size = new System.Drawing.Size(34, 20);
            this.pointBox2.TabIndex = 66;
            // 
            // gunDamage
            // 
            this.gunDamage.Location = new System.Drawing.Point(339, 101);
            this.gunDamage.Name = "gunDamage";
            this.gunDamage.Size = new System.Drawing.Size(31, 20);
            this.gunDamage.TabIndex = 67;
            // 
            // gunRange
            // 
            this.gunRange.Location = new System.Drawing.Point(387, 100);
            this.gunRange.Name = "gunRange";
            this.gunRange.Size = new System.Drawing.Size(31, 20);
            this.gunRange.TabIndex = 68;
            // 
            // meleeDamage
            // 
            this.meleeDamage.Location = new System.Drawing.Point(339, 141);
            this.meleeDamage.Name = "meleeDamage";
            this.meleeDamage.Size = new System.Drawing.Size(31, 20);
            this.meleeDamage.TabIndex = 69;
            // 
            // gunDamage2
            // 
            this.gunDamage2.Location = new System.Drawing.Point(339, 310);
            this.gunDamage2.Name = "gunDamage2";
            this.gunDamage2.Size = new System.Drawing.Size(31, 20);
            this.gunDamage2.TabIndex = 70;
            // 
            // gunRange2
            // 
            this.gunRange2.Location = new System.Drawing.Point(387, 310);
            this.gunRange2.Name = "gunRange2";
            this.gunRange2.Size = new System.Drawing.Size(31, 20);
            this.gunRange2.TabIndex = 71;
            // 
            // meleeDamage2
            // 
            this.meleeDamage2.Location = new System.Drawing.Point(339, 349);
            this.meleeDamage2.Name = "meleeDamage2";
            this.meleeDamage2.Size = new System.Drawing.Size(31, 20);
            this.meleeDamage2.TabIndex = 72;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(337, 87);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(47, 13);
            this.label35.TabIndex = 73;
            this.label35.Text = "Damage";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(337, 124);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(47, 13);
            this.label36.TabIndex = 74;
            this.label36.Text = "Damage";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(337, 294);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 13);
            this.label37.TabIndex = 75;
            this.label37.Text = "Damage";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(337, 333);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(47, 13);
            this.label38.TabIndex = 76;
            this.label38.Text = "Damage";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(390, 87);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(39, 13);
            this.label39.TabIndex = 77;
            this.label39.Text = "Range";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(390, 294);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(39, 13);
            this.label40.TabIndex = 78;
            this.label40.Text = "Range";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(519, 256);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(36, 13);
            this.label41.TabIndex = 79;
            this.label41.Text = "Points";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(519, 48);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(36, 13);
            this.label42.TabIndex = 80;
            this.label42.Text = "Points";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(640, 37);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(86, 13);
            this.label43.TabIndex = 81;
            this.label43.Text = "Wounds Caused";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(640, 71);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(81, 13);
            this.label44.TabIndex = 82;
            this.label44.Text = "Wounds Taken";
            // 
            // Model1LoadList
            // 
            this.Model1LoadList.FormattingEnabled = true;
            this.Model1LoadList.Location = new System.Drawing.Point(2, 87);
            this.Model1LoadList.Name = "Model1LoadList";
            this.Model1LoadList.Size = new System.Drawing.Size(120, 238);
            this.Model1LoadList.TabIndex = 83;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(-1, 71);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(75, 13);
            this.label46.TabIndex = 86;
            this.label46.Text = "Saved Profiles";
            // 
            // SaveModel2
            // 
            this.SaveModel2.Location = new System.Drawing.Point(2, 387);
            this.SaveModel2.Name = "SaveModel2";
            this.SaveModel2.Size = new System.Drawing.Size(85, 23);
            this.SaveModel2.TabIndex = 87;
            this.SaveModel2.Text = "Save Enemy";
            this.SaveModel2.UseVisualStyleBackColor = true;
            this.SaveModel2.Click += new System.EventHandler(this.saveModel2);
            // 
            // LoadModel2
            // 
            this.LoadModel2.Location = new System.Drawing.Point(2, 415);
            this.LoadModel2.Name = "LoadModel2";
            this.LoadModel2.Size = new System.Drawing.Size(85, 23);
            this.LoadModel2.TabIndex = 88;
            this.LoadModel2.Text = "Load Enemy";
            this.LoadModel2.UseVisualStyleBackColor = true;
            this.LoadModel2.Click += new System.EventHandler(this.loadModel2);
            // 
            // saveModel1
            // 
            this.saveModel1.Location = new System.Drawing.Point(2, 331);
            this.saveModel1.Name = "saveModel1";
            this.saveModel1.Size = new System.Drawing.Size(85, 23);
            this.saveModel1.TabIndex = 89;
            this.saveModel1.Text = "Save Current";
            this.saveModel1.UseVisualStyleBackColor = true;
            this.saveModel1.Click += new System.EventHandler(this.saveModel);
            // 
            // loadModel1
            // 
            this.loadModel1.Location = new System.Drawing.Point(2, 360);
            this.loadModel1.Name = "loadModel1";
            this.loadModel1.Size = new System.Drawing.Size(85, 23);
            this.loadModel1.TabIndex = 90;
            this.loadModel1.Text = "Load Current";
            this.loadModel1.UseVisualStyleBackColor = true;
            this.loadModel1.Click += new System.EventHandler(this.loadModel);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(131, 26);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(137, 20);
            this.nameBox.TabIndex = 91;
            // 
            // nameBox2
            // 
            this.nameBox2.Location = new System.Drawing.Point(132, 232);
            this.nameBox2.Name = "nameBox2";
            this.nameBox2.Size = new System.Drawing.Size(137, 20);
            this.nameBox2.TabIndex = 92;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(128, 216);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(71, 13);
            this.label47.TabIndex = 93;
            this.label47.Text = "Enemy Model";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(129, 12);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(73, 13);
            this.label48.TabIndex = 94;
            this.label48.Text = "Current Model";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 440);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.nameBox2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.loadModel1);
            this.Controls.Add(this.saveModel1);
            this.Controls.Add(this.LoadModel2);
            this.Controls.Add(this.SaveModel2);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.Model1LoadList);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.meleeDamage2);
            this.Controls.Add(this.gunRange2);
            this.Controls.Add(this.gunDamage2);
            this.Controls.Add(this.meleeDamage);
            this.Controls.Add(this.gunRange);
            this.Controls.Add(this.gunDamage);
            this.Controls.Add(this.pointBox2);
            this.Controls.Add(this.pointBox);
            this.Controls.Add(this.woundsTaken);
            this.Controls.Add(this.woundCaused);
            this.Controls.Add(this.calculateDamageButton);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.meleeMult2);
            this.Controls.Add(this.meleeRend2);
            this.Controls.Add(this.meleeS2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.gunShot2);
            this.Controls.Add(this.gunRend2);
            this.Controls.Add(this.gunS2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.saveBox2);
            this.Controls.Add(this.attackBox2);
            this.Controls.Add(this.woundBox2);
            this.Controls.Add(this.toughBox2);
            this.Controls.Add(this.strBox2);
            this.Controls.Add(this.BSBox2);
            this.Controls.Add(this.WSBox2);
            this.Controls.Add(this.moveBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.meleeMult);
            this.Controls.Add(this.meleeRend);
            this.Controls.Add(this.meleeS);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gunShot);
            this.Controls.Add(this.gunRend);
            this.Controls.Add(this.gunS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.attackBox);
            this.Controls.Add(this.woundBox);
            this.Controls.Add(this.toughBox);
            this.Controls.Add(this.strBox);
            this.Controls.Add(this.BSBox);
            this.Controls.Add(this.WSBox);
            this.Controls.Add(this.moveBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox moveBox;
        private System.Windows.Forms.TextBox WSBox;
        private System.Windows.Forms.TextBox BSBox;
        private System.Windows.Forms.TextBox strBox;
        private System.Windows.Forms.TextBox toughBox;
        private System.Windows.Forms.TextBox woundBox;
        private System.Windows.Forms.TextBox attackBox;
        private System.Windows.Forms.TextBox saveBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gunS;
        private System.Windows.Forms.TextBox gunRend;
        private System.Windows.Forms.TextBox gunShot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox meleeS;
        private System.Windows.Forms.TextBox meleeRend;
        private System.Windows.Forms.TextBox meleeMult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox meleeMult2;
        private System.Windows.Forms.TextBox meleeRend2;
        private System.Windows.Forms.TextBox meleeS2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox gunShot2;
        private System.Windows.Forms.TextBox gunRend2;
        private System.Windows.Forms.TextBox gunS2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox saveBox2;
        private System.Windows.Forms.TextBox attackBox2;
        private System.Windows.Forms.TextBox woundBox2;
        private System.Windows.Forms.TextBox toughBox2;
        private System.Windows.Forms.TextBox strBox2;
        private System.Windows.Forms.TextBox BSBox2;
        private System.Windows.Forms.TextBox WSBox2;
        private System.Windows.Forms.TextBox moveBox2;
        private System.Windows.Forms.Button calculateDamageButton;
        private System.Windows.Forms.TextBox woundCaused;
        private System.Windows.Forms.TextBox woundsTaken;
        private System.Windows.Forms.TextBox pointBox;
        private System.Windows.Forms.TextBox pointBox2;
        private System.Windows.Forms.TextBox gunDamage;
        private System.Windows.Forms.TextBox gunRange;
        private System.Windows.Forms.TextBox meleeDamage;
        private System.Windows.Forms.TextBox gunDamage2;
        private System.Windows.Forms.TextBox gunRange2;
        private System.Windows.Forms.TextBox meleeDamage2;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ListBox Model1LoadList;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button SaveModel2;
        private System.Windows.Forms.Button LoadModel2;
        private System.Windows.Forms.Button saveModel1;
        private System.Windows.Forms.Button loadModel1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox nameBox2;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
    }
}

