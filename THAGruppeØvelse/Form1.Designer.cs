
namespace THAGruppeØvelse
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mTxtBNavn = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBAdresse = new System.Windows.Forms.MaskedTextBox();
            this.lblNavn = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMedlemNr = new System.Windows.Forms.Label();
            this.mTxtBMedlemNr = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // mTxtBNavn
            // 
            this.mTxtBNavn.BackColor = System.Drawing.SystemColors.Window;
            this.mTxtBNavn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtBNavn.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtBNavn.Location = new System.Drawing.Point(42, 394);
            this.mTxtBNavn.Name = "mTxtBNavn";
            this.mTxtBNavn.Size = new System.Drawing.Size(100, 30);
            this.mTxtBNavn.TabIndex = 1;
            // 
            // mTxtBAdresse
            // 
            this.mTxtBAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtBAdresse.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtBAdresse.Location = new System.Drawing.Point(318, 392);
            this.mTxtBAdresse.Name = "mTxtBAdresse";
            this.mTxtBAdresse.Size = new System.Drawing.Size(100, 30);
            this.mTxtBAdresse.TabIndex = 2;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavn.ForeColor = System.Drawing.Color.White;
            this.lblNavn.Location = new System.Drawing.Point(37, 359);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(71, 30);
            this.lblNavn.TabIndex = 3;
            this.lblNavn.Text = "Navn";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.ForeColor = System.Drawing.Color.White;
            this.lblAdresse.Location = new System.Drawing.Point(313, 359);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(101, 30);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCreate.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(42, 470);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(132, 74);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Opret medlem";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.Yellow;
            this.btnRead.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(180, 470);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(132, 74);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Indlæs medlem";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(318, 470);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 74);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Opdater medlem";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(559, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 74);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Slet medlem";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMedlemNr
            // 
            this.lblMedlemNr.AutoSize = true;
            this.lblMedlemNr.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedlemNr.ForeColor = System.Drawing.Color.White;
            this.lblMedlemNr.Location = new System.Drawing.Point(554, 359);
            this.lblMedlemNr.Name = "lblMedlemNr";
            this.lblMedlemNr.Size = new System.Drawing.Size(137, 30);
            this.lblMedlemNr.TabIndex = 9;
            this.lblMedlemNr.Text = "Medlem Nr";
            // 
            // mTxtBMedlemNr
            // 
            this.mTxtBMedlemNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtBMedlemNr.Font = new System.Drawing.Font("Montserrat Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtBMedlemNr.Location = new System.Drawing.Point(559, 394);
            this.mTxtBMedlemNr.Name = "mTxtBMedlemNr";
            this.mTxtBMedlemNr.Size = new System.Drawing.Size(100, 30);
            this.mTxtBMedlemNr.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(744, 588);
            this.Controls.Add(this.mTxtBMedlemNr);
            this.Controls.Add(this.lblMedlemNr);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNavn);
            this.Controls.Add(this.mTxtBAdresse);
            this.Controls.Add(this.mTxtBNavn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mTxtBNavn;
        private System.Windows.Forms.MaskedTextBox mTxtBAdresse;
        private System.Windows.Forms.Label lblNavn;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMedlemNr;
        private System.Windows.Forms.MaskedTextBox mTxtBMedlemNr;
    }
}

