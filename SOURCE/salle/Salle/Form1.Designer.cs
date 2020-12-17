namespace WinForm
{
    partial class ChefMaster
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefMaster));
            this.Commencer = new System.Windows.Forms.Button();
            this.Arreter = new System.Windows.Forms.Button();
            this.Heures = new System.Windows.Forms.TextBox();
            this.Seconde = new System.Windows.Forms.TextBox();
            this.Minutes = new System.Windows.Forms.TextBox();
            this.Jour = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.NBpers_Tab1 = new System.Windows.Forms.Label();
            this.NBpers_Tab2 = new System.Windows.Forms.Label();
            this.NBpers_Tab3 = new System.Windows.Forms.Label();
            this.NBpers_Tab4 = new System.Windows.Forms.Label();
            this.NBpers_Tab2_1 = new System.Windows.Forms.Label();
            this.NBpers_Tab2_2 = new System.Windows.Forms.Label();
            this.NBpers_Tab2_3 = new System.Windows.Forms.Label();
            this.NBpers_Tab2_4 = new System.Windows.Forms.Label();
            this.NBpers_Tab4_1 = new System.Windows.Forms.Label();
            this.NBpers_Tab3_1 = new System.Windows.Forms.Label();
            this.NBpers_Tab3_2 = new System.Windows.Forms.Label();
            this.NBpers_Tab4_2 = new System.Windows.Forms.Label();
            this.NBpers_Tab3_3 = new System.Windows.Forms.Label();
            this.NBpers_Tab4_3 = new System.Windows.Forms.Label();
            this.PainEau_Tab1 = new System.Windows.Forms.Label();
            this.PainEau_Tab2 = new System.Windows.Forms.Label();
            this.PainEau_Tab3 = new System.Windows.Forms.Label();
            this.PainEau_Tab2_4 = new System.Windows.Forms.Label();
            this.PainEau_Tab4 = new System.Windows.Forms.Label();
            this.PainEau_Tab2_3 = new System.Windows.Forms.Label();
            this.PainEau_Tab2_1 = new System.Windows.Forms.Label();
            this.PainEau_Tab3_1 = new System.Windows.Forms.Label();
            this.PainEau_Tab4_1 = new System.Windows.Forms.Label();
            this.PainEau_Tab3_2 = new System.Windows.Forms.Label();
            this.PainEau_Tab4_3 = new System.Windows.Forms.Label();
            this.PainEau_Tab4_2 = new System.Windows.Forms.Label();
            this.PainEau_Tab3_3 = new System.Windows.Forms.Label();
            this.PainEau_Tab2_2 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_1 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_2 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_3 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_4 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_2_1 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_2_2 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_2_3 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_2_4 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_3_1 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_4_1 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_4_2 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_4_3 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_3_3 = new System.Windows.Forms.Label();
            this.ClientMnge_Tab_3_2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Vitesse = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.SuspendLayout();
            // 
            // Commencer
            // 
            this.Commencer.Location = new System.Drawing.Point(17, 10);
            this.Commencer.Name = "Commencer";
            this.Commencer.Size = new System.Drawing.Size(75, 23);
            this.Commencer.TabIndex = 1;
            this.Commencer.Text = "Start";
            this.Commencer.UseVisualStyleBackColor = true;
            this.Commencer.Click += new System.EventHandler(this.commencer);
            // 
            // Arreter
            // 
            this.Arreter.Location = new System.Drawing.Point(109, 7);
            this.Arreter.Name = "Arreter";
            this.Arreter.Size = new System.Drawing.Size(75, 28);
            this.Arreter.TabIndex = 2;
            this.Arreter.Text = "Stop";
            this.Arreter.UseVisualStyleBackColor = true;
            this.Arreter.Click += new System.EventHandler(this.Arreter_Click);
            // 
            // Heures
            // 
            this.Heures.Location = new System.Drawing.Point(807, 15);
            this.Heures.Name = "Heures";
            this.Heures.Size = new System.Drawing.Size(23, 20);
            this.Heures.TabIndex = 5;
            this.Heures.Text = "0";
            this.Heures.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Seconde
            // 
            this.Seconde.Location = new System.Drawing.Point(869, 15);
            this.Seconde.Name = "Seconde";
            this.Seconde.Size = new System.Drawing.Size(26, 20);
            this.Seconde.TabIndex = 6;
            this.Seconde.Text = "0";
            this.Seconde.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(836, 15);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(27, 20);
            this.Minutes.TabIndex = 7;
            this.Minutes.Text = "0";
            this.Minutes.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Jour
            // 
            this.Jour.Location = new System.Drawing.Point(772, 15);
            this.Jour.Name = "Jour";
            this.Jour.Size = new System.Drawing.Size(29, 20);
            this.Jour.TabIndex = 8;
            this.Jour.Text = "0";
            this.Jour.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(294, 3);
            this.trackBar2.Maximum = 4;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(94, 45);
            this.trackBar2.TabIndex = 11;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 638);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "Recevoir client\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ArriveCli_Click);
            // 
            // NBpers_Tab1
            // 
            this.NBpers_Tab1.AutoSize = true;
            this.NBpers_Tab1.Location = new System.Drawing.Point(301, 474);
            this.NBpers_Tab1.Name = "NBpers_Tab1";
            this.NBpers_Tab1.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab1.TabIndex = 23;
            this.NBpers_Tab1.Text = "Vide";
            // 
            // NBpers_Tab2
            // 
            this.NBpers_Tab2.AutoSize = true;
            this.NBpers_Tab2.Location = new System.Drawing.Point(416, 431);
            this.NBpers_Tab2.Name = "NBpers_Tab2";
            this.NBpers_Tab2.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab2.TabIndex = 24;
            this.NBpers_Tab2.Text = "Vide";
            // 
            // NBpers_Tab3
            // 
            this.NBpers_Tab3.AutoSize = true;
            this.NBpers_Tab3.Location = new System.Drawing.Point(554, 458);
            this.NBpers_Tab3.Name = "NBpers_Tab3";
            this.NBpers_Tab3.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab3.TabIndex = 25;
            this.NBpers_Tab3.Text = "Vide";
            // 
            // NBpers_Tab4
            // 
            this.NBpers_Tab4.AutoSize = true;
            this.NBpers_Tab4.Location = new System.Drawing.Point(664, 431);
            this.NBpers_Tab4.Name = "NBpers_Tab4";
            this.NBpers_Tab4.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab4.TabIndex = 26;
            this.NBpers_Tab4.Text = "Vide";
            // 
            // NBpers_Tab2_1
            // 
            this.NBpers_Tab2_1.AutoSize = true;
            this.NBpers_Tab2_1.Location = new System.Drawing.Point(301, 632);
            this.NBpers_Tab2_1.Name = "NBpers_Tab2_1";
            this.NBpers_Tab2_1.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab2_1.TabIndex = 27;
            this.NBpers_Tab2_1.Text = "Vide";
            // 
            // NBpers_Tab2_2
            // 
            this.NBpers_Tab2_2.AutoSize = true;
            this.NBpers_Tab2_2.Location = new System.Drawing.Point(416, 566);
            this.NBpers_Tab2_2.Name = "NBpers_Tab2_2";
            this.NBpers_Tab2_2.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab2_2.TabIndex = 28;
            this.NBpers_Tab2_2.Text = "Vide";
            // 
            // NBpers_Tab2_3
            // 
            this.NBpers_Tab2_3.AutoSize = true;
            this.NBpers_Tab2_3.Location = new System.Drawing.Point(542, 638);
            this.NBpers_Tab2_3.Name = "NBpers_Tab2_3";
            this.NBpers_Tab2_3.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab2_3.TabIndex = 29;
            this.NBpers_Tab2_3.Text = "Vide";
            // 
            // NBpers_Tab2_4
            // 
            this.NBpers_Tab2_4.AutoSize = true;
            this.NBpers_Tab2_4.Location = new System.Drawing.Point(664, 566);
            this.NBpers_Tab2_4.Name = "NBpers_Tab2_4";
            this.NBpers_Tab2_4.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab2_4.TabIndex = 30;
            this.NBpers_Tab2_4.Text = "Vide";
            // 
            // NBpers_Tab4_1
            // 
            this.NBpers_Tab4_1.AutoSize = true;
            this.NBpers_Tab4_1.Location = new System.Drawing.Point(812, 632);
            this.NBpers_Tab4_1.Name = "NBpers_Tab4_1";
            this.NBpers_Tab4_1.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab4_1.TabIndex = 31;
            this.NBpers_Tab4_1.Text = "Vide";
            // 
            // NBpers_Tab3_1
            // 
            this.NBpers_Tab3_1.AutoSize = true;
            this.NBpers_Tab3_1.Location = new System.Drawing.Point(792, 431);
            this.NBpers_Tab3_1.Name = "NBpers_Tab3_1";
            this.NBpers_Tab3_1.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab3_1.TabIndex = 31;
            this.NBpers_Tab3_1.Text = "Vide";
            // 
            // NBpers_Tab3_2
            // 
            this.NBpers_Tab3_2.AutoSize = true;
            this.NBpers_Tab3_2.Location = new System.Drawing.Point(970, 440);
            this.NBpers_Tab3_2.Name = "NBpers_Tab3_2";
            this.NBpers_Tab3_2.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab3_2.TabIndex = 32;
            this.NBpers_Tab3_2.Text = "Vide";
            // 
            // NBpers_Tab4_2
            // 
            this.NBpers_Tab4_2.AutoSize = true;
            this.NBpers_Tab4_2.Location = new System.Drawing.Point(934, 578);
            this.NBpers_Tab4_2.Name = "NBpers_Tab4_2";
            this.NBpers_Tab4_2.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab4_2.TabIndex = 33;
            this.NBpers_Tab4_2.Text = "Vide";
            // 
            // NBpers_Tab3_3
            // 
            this.NBpers_Tab3_3.AutoSize = true;
            this.NBpers_Tab3_3.Location = new System.Drawing.Point(1089, 422);
            this.NBpers_Tab3_3.Name = "NBpers_Tab3_3";
            this.NBpers_Tab3_3.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab3_3.TabIndex = 34;
            this.NBpers_Tab3_3.Text = "Vide";
            // 
            // NBpers_Tab4_3
            // 
            this.NBpers_Tab4_3.AutoSize = true;
            this.NBpers_Tab4_3.Location = new System.Drawing.Point(1114, 632);
            this.NBpers_Tab4_3.Name = "NBpers_Tab4_3";
            this.NBpers_Tab4_3.Size = new System.Drawing.Size(28, 13);
            this.NBpers_Tab4_3.TabIndex = 35;
            this.NBpers_Tab4_3.Text = "Vide";
            // 
            // PainEau_Tab1
            // 
            this.PainEau_Tab1.AutoSize = true;
            this.PainEau_Tab1.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab1.Location = new System.Drawing.Point(301, 566);
            this.PainEau_Tab1.Name = "PainEau_Tab1";
            this.PainEau_Tab1.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab1.TabIndex = 36;
            this.PainEau_Tab1.Text = "Pain et Eau";
            // 
            // PainEau_Tab2
            // 
            this.PainEau_Tab2.AutoSize = true;
            this.PainEau_Tab2.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab2.Location = new System.Drawing.Point(425, 522);
            this.PainEau_Tab2.Name = "PainEau_Tab2";
            this.PainEau_Tab2.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab2.TabIndex = 37;
            this.PainEau_Tab2.Text = "Pain et Eau";
            // 
            // PainEau_Tab3
            // 
            this.PainEau_Tab3.AutoSize = true;
            this.PainEau_Tab3.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab3.Location = new System.Drawing.Point(564, 554);
            this.PainEau_Tab3.Name = "PainEau_Tab3";
            this.PainEau_Tab3.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab3.TabIndex = 38;
            this.PainEau_Tab3.Text = "Pain et Eau";
            // 
            // PainEau_Tab2_4
            // 
            this.PainEau_Tab2_4.AutoSize = true;
            this.PainEau_Tab2_4.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab2_4.Location = new System.Drawing.Point(682, 660);
            this.PainEau_Tab2_4.Name = "PainEau_Tab2_4";
            this.PainEau_Tab2_4.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab2_4.TabIndex = 39;
            this.PainEau_Tab2_4.Text = "Pain et Eau";
            // 
            // PainEau_Tab4
            // 
            this.PainEau_Tab4.AutoSize = true;
            this.PainEau_Tab4.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab4.Location = new System.Drawing.Point(692, 522);
            this.PainEau_Tab4.Name = "PainEau_Tab4";
            this.PainEau_Tab4.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab4.TabIndex = 39;
            this.PainEau_Tab4.Text = "Pain et Eau";
            // 
            // PainEau_Tab2_3
            // 
            this.PainEau_Tab2_3.AutoSize = true;
            this.PainEau_Tab2_3.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab2_3.Location = new System.Drawing.Point(576, 687);
            this.PainEau_Tab2_3.Name = "PainEau_Tab2_3";
            this.PainEau_Tab2_3.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab2_3.TabIndex = 39;
            this.PainEau_Tab2_3.Text = "Pain et Eau";
            // 
            // PainEau_Tab2_1
            // 
            this.PainEau_Tab2_1.AutoSize = true;
            this.PainEau_Tab2_1.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab2_1.Location = new System.Drawing.Point(313, 687);
            this.PainEau_Tab2_1.Name = "PainEau_Tab2_1";
            this.PainEau_Tab2_1.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab2_1.TabIndex = 40;
            this.PainEau_Tab2_1.Text = "Pain et Eau";
            // 
            // PainEau_Tab3_1
            // 
            this.PainEau_Tab3_1.AutoSize = true;
            this.PainEau_Tab3_1.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab3_1.Location = new System.Drawing.Point(843, 539);
            this.PainEau_Tab3_1.Name = "PainEau_Tab3_1";
            this.PainEau_Tab3_1.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab3_1.TabIndex = 41;
            this.PainEau_Tab3_1.Text = "Pain et Eau";
            // 
            // PainEau_Tab4_1
            // 
            this.PainEau_Tab4_1.AutoSize = true;
            this.PainEau_Tab4_1.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab4_1.Location = new System.Drawing.Point(845, 687);
            this.PainEau_Tab4_1.Name = "PainEau_Tab4_1";
            this.PainEau_Tab4_1.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab4_1.TabIndex = 42;
            this.PainEau_Tab4_1.Text = "Pain et Eau";
            // 
            // PainEau_Tab3_2
            // 
            this.PainEau_Tab3_2.AutoSize = true;
            this.PainEau_Tab3_2.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab3_2.Location = new System.Drawing.Point(985, 539);
            this.PainEau_Tab3_2.Name = "PainEau_Tab3_2";
            this.PainEau_Tab3_2.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab3_2.TabIndex = 43;
            this.PainEau_Tab3_2.Text = "Pain et Eau";
            // 
            // PainEau_Tab4_3
            // 
            this.PainEau_Tab4_3.AutoSize = true;
            this.PainEau_Tab4_3.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab4_3.Location = new System.Drawing.Point(1150, 687);
            this.PainEau_Tab4_3.Name = "PainEau_Tab4_3";
            this.PainEau_Tab4_3.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab4_3.TabIndex = 44;
            this.PainEau_Tab4_3.Text = "Pain et Eau";
            // 
            // PainEau_Tab4_2
            // 
            this.PainEau_Tab4_2.AutoSize = true;
            this.PainEau_Tab4_2.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab4_2.Location = new System.Drawing.Point(985, 687);
            this.PainEau_Tab4_2.Name = "PainEau_Tab4_2";
            this.PainEau_Tab4_2.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab4_2.TabIndex = 44;
            this.PainEau_Tab4_2.Text = "Pain et Eau";
            // 
            // PainEau_Tab3_3
            // 
            this.PainEau_Tab3_3.AutoSize = true;
            this.PainEau_Tab3_3.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab3_3.Location = new System.Drawing.Point(1128, 554);
            this.PainEau_Tab3_3.Name = "PainEau_Tab3_3";
            this.PainEau_Tab3_3.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab3_3.TabIndex = 45;
            this.PainEau_Tab3_3.Text = "Pain et Eau";
            // 
            // PainEau_Tab2_2
            // 
            this.PainEau_Tab2_2.AutoSize = true;
            this.PainEau_Tab2_2.ForeColor = System.Drawing.Color.Red;
            this.PainEau_Tab2_2.Location = new System.Drawing.Point(434, 660);
            this.PainEau_Tab2_2.Name = "PainEau_Tab2_2";
            this.PainEau_Tab2_2.Size = new System.Drawing.Size(62, 13);
            this.PainEau_Tab2_2.TabIndex = 46;
            this.PainEau_Tab2_2.Text = "Pain et Eau";
            // 
            // ClientMnge_Tab_1
            // 
            this.ClientMnge_Tab_1.AutoSize = true;
            this.ClientMnge_Tab_1.Location = new System.Drawing.Point(362, 474);
            this.ClientMnge_Tab_1.Name = "ClientMnge_Tab_1";
            this.ClientMnge_Tab_1.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_1.TabIndex = 47;
            this.ClientMnge_Tab_1.Text = "-";
            // 
            // ClientMnge_Tab_2
            // 
            this.ClientMnge_Tab_2.AutoSize = true;
            this.ClientMnge_Tab_2.Location = new System.Drawing.Point(489, 431);
            this.ClientMnge_Tab_2.Name = "ClientMnge_Tab_2";
            this.ClientMnge_Tab_2.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_2.TabIndex = 48;
            this.ClientMnge_Tab_2.Text = "-";
            // 
            // ClientMnge_Tab_3
            // 
            this.ClientMnge_Tab_3.AutoSize = true;
            this.ClientMnge_Tab_3.Location = new System.Drawing.Point(627, 458);
            this.ClientMnge_Tab_3.Name = "ClientMnge_Tab_3";
            this.ClientMnge_Tab_3.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_3.TabIndex = 49;
            this.ClientMnge_Tab_3.Text = "-";
            // 
            // ClientMnge_Tab_4
            // 
            this.ClientMnge_Tab_4.AutoSize = true;
            this.ClientMnge_Tab_4.Location = new System.Drawing.Point(756, 431);
            this.ClientMnge_Tab_4.Name = "ClientMnge_Tab_4";
            this.ClientMnge_Tab_4.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_4.TabIndex = 50;
            this.ClientMnge_Tab_4.Text = "-";
            // 
            // ClientMnge_Tab_2_1
            // 
            this.ClientMnge_Tab_2_1.AutoSize = true;
            this.ClientMnge_Tab_2_1.Location = new System.Drawing.Point(362, 632);
            this.ClientMnge_Tab_2_1.Name = "ClientMnge_Tab_2_1";
            this.ClientMnge_Tab_2_1.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_2_1.TabIndex = 51;
            this.ClientMnge_Tab_2_1.Text = "-";
            // 
            // ClientMnge_Tab_2_2
            // 
            this.ClientMnge_Tab_2_2.AutoSize = true;
            this.ClientMnge_Tab_2_2.Location = new System.Drawing.Point(489, 566);
            this.ClientMnge_Tab_2_2.Name = "ClientMnge_Tab_2_2";
            this.ClientMnge_Tab_2_2.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_2_2.TabIndex = 52;
            this.ClientMnge_Tab_2_2.Text = "-";
            // 
            // ClientMnge_Tab_2_3
            // 
            this.ClientMnge_Tab_2_3.AutoSize = true;
            this.ClientMnge_Tab_2_3.Location = new System.Drawing.Point(627, 632);
            this.ClientMnge_Tab_2_3.Name = "ClientMnge_Tab_2_3";
            this.ClientMnge_Tab_2_3.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_2_3.TabIndex = 53;
            this.ClientMnge_Tab_2_3.Text = "-";
            // 
            // ClientMnge_Tab_2_4
            // 
            this.ClientMnge_Tab_2_4.AutoSize = true;
            this.ClientMnge_Tab_2_4.Location = new System.Drawing.Point(735, 566);
            this.ClientMnge_Tab_2_4.Name = "ClientMnge_Tab_2_4";
            this.ClientMnge_Tab_2_4.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_2_4.TabIndex = 54;
            this.ClientMnge_Tab_2_4.Text = "-";
            // 
            // ClientMnge_Tab_3_1
            // 
            this.ClientMnge_Tab_3_1.AutoSize = true;
            this.ClientMnge_Tab_3_1.Location = new System.Drawing.Point(792, 522);
            this.ClientMnge_Tab_3_1.Name = "ClientMnge_Tab_3_1";
            this.ClientMnge_Tab_3_1.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_3_1.TabIndex = 55;
            this.ClientMnge_Tab_3_1.Text = "-";
            // 
            // ClientMnge_Tab_4_1
            // 
            this.ClientMnge_Tab_4_1.AutoSize = true;
            this.ClientMnge_Tab_4_1.Location = new System.Drawing.Point(895, 632);
            this.ClientMnge_Tab_4_1.Name = "ClientMnge_Tab_4_1";
            this.ClientMnge_Tab_4_1.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_4_1.TabIndex = 56;
            this.ClientMnge_Tab_4_1.Text = "-";
            // 
            // ClientMnge_Tab_4_2
            // 
            this.ClientMnge_Tab_4_2.AutoSize = true;
            this.ClientMnge_Tab_4_2.Location = new System.Drawing.Point(1073, 578);
            this.ClientMnge_Tab_4_2.Name = "ClientMnge_Tab_4_2";
            this.ClientMnge_Tab_4_2.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_4_2.TabIndex = 57;
            this.ClientMnge_Tab_4_2.Text = "-";
            // 
            // ClientMnge_Tab_4_3
            // 
            this.ClientMnge_Tab_4_3.AutoSize = true;
            this.ClientMnge_Tab_4_3.Location = new System.Drawing.Point(1190, 632);
            this.ClientMnge_Tab_4_3.Name = "ClientMnge_Tab_4_3";
            this.ClientMnge_Tab_4_3.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_4_3.TabIndex = 58;
            this.ClientMnge_Tab_4_3.Text = "-";
            // 
            // ClientMnge_Tab_3_3
            // 
            this.ClientMnge_Tab_3_3.AutoSize = true;
            this.ClientMnge_Tab_3_3.Location = new System.Drawing.Point(1089, 539);
            this.ClientMnge_Tab_3_3.Name = "ClientMnge_Tab_3_3";
            this.ClientMnge_Tab_3_3.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_3_3.TabIndex = 59;
            this.ClientMnge_Tab_3_3.Text = "-";
            // 
            // ClientMnge_Tab_3_2
            // 
            this.ClientMnge_Tab_3_2.AutoSize = true;
            this.ClientMnge_Tab_3_2.Location = new System.Drawing.Point(1051, 440);
            this.ClientMnge_Tab_3_2.Name = "ClientMnge_Tab_3_2";
            this.ClientMnge_Tab_3_2.Size = new System.Drawing.Size(10, 13);
            this.ClientMnge_Tab_3_2.TabIndex = 60;
            this.ClientMnge_Tab_3_2.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 45);
            this.button2.TabIndex = 61;
            this.button2.Text = "Plat Pret";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Plat_pret_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nombre de Clients";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Feuillete au crabe",
            "Oeufs cocotte",
            "Bouillinade d\'anguilles ou de poissons",
            "Boles de picoulats",
            "Blanquette de veau",
            "Gaspatcho"});
            this.comboBox2.Location = new System.Drawing.Point(119, 446);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 21);
            this.comboBox2.TabIndex = 65;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Feuillete au crabe",
            "Oeufs cocotte",
            "Bouillinade d\'anguilles ou de poissons",
            "Boles de picoulats",
            "Blanquette de veau",
            "Gaspatcho"});
            this.comboBox3.Location = new System.Drawing.Point(119, 481);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(135, 21);
            this.comboBox3.TabIndex = 66;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Feuillete au crabe",
            "Oeufs cocotte",
            "Bouillinade d\'anguilles ou de poissons",
            "Boles de picoulats",
            "Blanquette de veau",
            "Gaspatcho"});
            this.comboBox4.Location = new System.Drawing.Point(119, 513);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(135, 21);
            this.comboBox4.TabIndex = 67;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Feuillete au crabe",
            "Oeufs cocotte",
            "Bouillinade d\'anguilles ou de poissons",
            "Boles de picoulats",
            "Blanquette de veau",
            "Gaspatcho"});
            this.comboBox5.Location = new System.Drawing.Point(119, 545);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(135, 21);
            this.comboBox5.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Type clients";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Cool (1h)",
            "Presse (30min)"});
            this.comboBox8.Location = new System.Drawing.Point(119, 412);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(135, 21);
            this.comboBox8.TabIndex = 72;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox9.Location = new System.Drawing.Point(119, 372);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(135, 21);
            this.comboBox9.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Choix 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Choix 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Choix 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Choix 4";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(836, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 45);
            this.button5.TabIndex = 80;
            this.button5.Text = "Repas Terminé";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // Vitesse
            // 
            this.Vitesse.AutoSize = true;
            this.Vitesse.Location = new System.Drawing.Point(217, 15);
            this.Vitesse.Name = "Vitesse";
            this.Vitesse.Size = new System.Drawing.Size(41, 13);
            this.Vitesse.TabIndex = 91;
            this.Vitesse.Text = "Vitesse";
            this.Vitesse.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(9, 54);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(1319, 674);
            this.pictureBox17.TabIndex = 93;
            this.pictureBox17.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Choix 5";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Feuillete au crabe",
            "Oeufs cocotte",
            "Bouillinade d\'anguilles ou de poissons",
            "Boles de picoulats",
            "Blanquette de veau",
            "Gaspatcho"});
            this.comboBox6.Location = new System.Drawing.Point(119, 581);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(135, 21);
            this.comboBox6.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 97;
            this.label9.Text = "Choix 6";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Feuillete au crabe",
            "Oeufs cocotte",
            "Bouillinade d\'anguilles ou de poissons",
            "Boles de picoulats",
            "Blanquette de veau",
            "Gaspatcho"});
            this.comboBox7.Location = new System.Drawing.Point(119, 611);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(135, 21);
            this.comboBox7.TabIndex = 96;
            // 
            // ChefMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 740);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.Vitesse);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClientMnge_Tab_3_2);
            this.Controls.Add(this.ClientMnge_Tab_3_3);
            this.Controls.Add(this.ClientMnge_Tab_4_3);
            this.Controls.Add(this.ClientMnge_Tab_4_2);
            this.Controls.Add(this.ClientMnge_Tab_4_1);
            this.Controls.Add(this.ClientMnge_Tab_3_1);
            this.Controls.Add(this.ClientMnge_Tab_2_4);
            this.Controls.Add(this.ClientMnge_Tab_2_3);
            this.Controls.Add(this.ClientMnge_Tab_2_2);
            this.Controls.Add(this.ClientMnge_Tab_2_1);
            this.Controls.Add(this.ClientMnge_Tab_4);
            this.Controls.Add(this.ClientMnge_Tab_3);
            this.Controls.Add(this.ClientMnge_Tab_2);
            this.Controls.Add(this.ClientMnge_Tab_1);
            this.Controls.Add(this.PainEau_Tab2_2);
            this.Controls.Add(this.PainEau_Tab3_3);
            this.Controls.Add(this.PainEau_Tab4_2);
            this.Controls.Add(this.PainEau_Tab4_3);
            this.Controls.Add(this.PainEau_Tab3_2);
            this.Controls.Add(this.PainEau_Tab4_1);
            this.Controls.Add(this.PainEau_Tab3_1);
            this.Controls.Add(this.PainEau_Tab2_1);
            this.Controls.Add(this.PainEau_Tab4);
            this.Controls.Add(this.PainEau_Tab2_3);
            this.Controls.Add(this.PainEau_Tab2_4);
            this.Controls.Add(this.PainEau_Tab3);
            this.Controls.Add(this.PainEau_Tab1);
            this.Controls.Add(this.PainEau_Tab2);
            this.Controls.Add(this.NBpers_Tab4_3);
            this.Controls.Add(this.NBpers_Tab3_3);
            this.Controls.Add(this.NBpers_Tab4_2);
            this.Controls.Add(this.NBpers_Tab3_2);
            this.Controls.Add(this.NBpers_Tab3_1);
            this.Controls.Add(this.NBpers_Tab4_1);
            this.Controls.Add(this.NBpers_Tab2_4);
            this.Controls.Add(this.NBpers_Tab2_3);
            this.Controls.Add(this.NBpers_Tab2_2);
            this.Controls.Add(this.NBpers_Tab2_1);
            this.Controls.Add(this.NBpers_Tab4);
            this.Controls.Add(this.NBpers_Tab3);
            this.Controls.Add(this.NBpers_Tab2);
            this.Controls.Add(this.NBpers_Tab1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.Jour);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Seconde);
            this.Controls.Add(this.Heures);
            this.Controls.Add(this.Arreter);
            this.Controls.Add(this.Commencer);
            this.Controls.Add(this.pictureBox17);
            this.Name = "ChefMaster";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.TextBox minute;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TrackBar trackBar1;
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Commencer;
        private System.Windows.Forms.Button Arreter;
        private System.Windows.Forms.TextBox Heures;
        private System.Windows.Forms.TextBox Seconde;
        private System.Windows.Forms.TextBox Minutes;
        private System.Windows.Forms.TextBox Jour;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NBpers_Tab1;
        private System.Windows.Forms.Label NBpers_Tab2;
        private System.Windows.Forms.Label NBpers_Tab3;
        private System.Windows.Forms.Label NBpers_Tab4;
        private System.Windows.Forms.Label NBpers_Tab2_1;
        private System.Windows.Forms.Label NBpers_Tab2_2;
        private System.Windows.Forms.Label NBpers_Tab2_3;
        private System.Windows.Forms.Label NBpers_Tab2_4;
        private System.Windows.Forms.Label NBpers_Tab4_1;
        private System.Windows.Forms.Label NBpers_Tab3_1;
        private System.Windows.Forms.Label NBpers_Tab3_2;
        private System.Windows.Forms.Label NBpers_Tab4_2;
        private System.Windows.Forms.Label NBpers_Tab3_3;
        private System.Windows.Forms.Label NBpers_Tab4_3;
        private System.Windows.Forms.Label PainEau_Tab1;
        private System.Windows.Forms.Label PainEau_Tab2;
        private System.Windows.Forms.Label PainEau_Tab3;
        private System.Windows.Forms.Label PainEau_Tab2_4;
        private System.Windows.Forms.Label PainEau_Tab4;
        private System.Windows.Forms.Label PainEau_Tab2_3;
        private System.Windows.Forms.Label PainEau_Tab2_1;
        private System.Windows.Forms.Label PainEau_Tab3_1;
        private System.Windows.Forms.Label PainEau_Tab4_1;
        private System.Windows.Forms.Label PainEau_Tab3_2;
        private System.Windows.Forms.Label PainEau_Tab4_3;
        private System.Windows.Forms.Label PainEau_Tab4_2;
        private System.Windows.Forms.Label PainEau_Tab3_3;
        private System.Windows.Forms.Label PainEau_Tab2_2;
        private System.Windows.Forms.Label ClientMnge_Tab_1;
        private System.Windows.Forms.Label ClientMnge_Tab_2;
        private System.Windows.Forms.Label ClientMnge_Tab_3;
        private System.Windows.Forms.Label ClientMnge_Tab_4;
        private System.Windows.Forms.Label ClientMnge_Tab_2_1;
        private System.Windows.Forms.Label ClientMnge_Tab_2_2;
        private System.Windows.Forms.Label ClientMnge_Tab_2_3;
        private System.Windows.Forms.Label ClientMnge_Tab_2_4;
        private System.Windows.Forms.Label ClientMnge_Tab_3_1;
        private System.Windows.Forms.Label ClientMnge_Tab_4_1;
        private System.Windows.Forms.Label ClientMnge_Tab_4_2;
        private System.Windows.Forms.Label ClientMnge_Tab_4_3;
        private System.Windows.Forms.Label ClientMnge_Tab_3_3;
        private System.Windows.Forms.Label ClientMnge_Tab_3_2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Vitesse;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox7;
    }
}

