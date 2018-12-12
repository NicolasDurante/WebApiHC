namespace Fronend.Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btTraerDatos = new System.Windows.Forms.Button();
            this.textboxDatos = new System.Windows.Forms.TextBox();
            this.btPost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxProvincia_Persona_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbPersona_id = new System.Windows.Forms.TextBox();
            this.txtbDNI = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.btput = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.textBSexo = new System.Windows.Forms.TextBox();
            this.textBEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBCelular = new System.Windows.Forms.TextBox();
            this.textBEmail = new System.Windows.Forms.TextBox();
            this.textBEstadoCivil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBProv_na = new System.Windows.Forms.TextBox();
            this.textBNacionalidad = new System.Windows.Forms.TextBox();
            this.textBFechaNac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBTelFijo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxapelido = new System.Windows.Forms.TextBox();
            this.txtboxDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // btTraerDatos
            // 
            this.btTraerDatos.Location = new System.Drawing.Point(12, 13);
            this.btTraerDatos.Name = "btTraerDatos";
            this.btTraerDatos.Size = new System.Drawing.Size(93, 43);
            this.btTraerDatos.TabIndex = 1;
            this.btTraerDatos.Text = "Get";
            this.btTraerDatos.UseVisualStyleBackColor = true;
            this.btTraerDatos.Click += new System.EventHandler(this.btTraerDatos_Click);
            // 
            // textboxDatos
            // 
            this.textboxDatos.Location = new System.Drawing.Point(111, 21);
            this.textboxDatos.Name = "textboxDatos";
            this.textboxDatos.Size = new System.Drawing.Size(156, 20);
            this.textboxDatos.TabIndex = 2;
            this.textboxDatos.Text = "Personas";
            // 
            // btPost
            // 
            this.btPost.Location = new System.Drawing.Point(12, 69);
            this.btPost.Name = "btPost";
            this.btPost.Size = new System.Drawing.Size(93, 43);
            this.btPost.TabIndex = 3;
            this.btPost.Text = "Post";
            this.btPost.UseVisualStyleBackColor = true;
            this.btPost.Click += new System.EventHandler(this.btPost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Persona_id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI:";
            // 
            // txtboxProvincia_Persona_id
            // 
            this.txtboxProvincia_Persona_id.AutoSize = true;
            this.txtboxProvincia_Persona_id.Location = new System.Drawing.Point(565, 99);
            this.txtboxProvincia_Persona_id.Name = "txtboxProvincia_Persona_id";
            this.txtboxProvincia_Persona_id.Size = new System.Drawing.Size(47, 13);
            this.txtboxProvincia_Persona_id.TabIndex = 7;
            this.txtboxProvincia_Persona_id.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ejemplo objeto Persona";
            // 
            // txtbPersona_id
            // 
            this.txtbPersona_id.Location = new System.Drawing.Point(618, 40);
            this.txtbPersona_id.Name = "txtbPersona_id";
            this.txtbPersona_id.Size = new System.Drawing.Size(135, 20);
            this.txtbPersona_id.TabIndex = 9;
            // 
            // txtbDNI
            // 
            this.txtbDNI.Location = new System.Drawing.Point(618, 66);
            this.txtbDNI.Name = "txtbDNI";
            this.txtbDNI.Size = new System.Drawing.Size(135, 20);
            this.txtbDNI.TabIndex = 10;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(618, 92);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(135, 20);
            this.txtbNombre.TabIndex = 11;
            // 
            // btput
            // 
            this.btput.Location = new System.Drawing.Point(12, 121);
            this.btput.Name = "btput";
            this.btput.Size = new System.Drawing.Size(93, 43);
            this.btput.TabIndex = 12;
            this.btput.Text = "Put";
            this.btput.UseVisualStyleBackColor = true;
            this.btput.Click += new System.EventHandler(this.btput_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(12, 327);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(93, 43);
            this.btdelete.TabIndex = 13;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // textBSexo
            // 
            this.textBSexo.Location = new System.Drawing.Point(618, 170);
            this.textBSexo.Name = "textBSexo";
            this.textBSexo.Size = new System.Drawing.Size(135, 20);
            this.textBSexo.TabIndex = 19;
            // 
            // textBEdad
            // 
            this.textBEdad.Location = new System.Drawing.Point(618, 144);
            this.textBEdad.Name = "textBEdad";
            this.textBEdad.Size = new System.Drawing.Size(135, 20);
            this.textBEdad.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Apellido:";
            // 
            // textBCelular
            // 
            this.textBCelular.Location = new System.Drawing.Point(618, 249);
            this.textBCelular.Name = "textBCelular";
            this.textBCelular.Size = new System.Drawing.Size(135, 20);
            this.textBCelular.TabIndex = 25;
            // 
            // textBEmail
            // 
            this.textBEmail.Location = new System.Drawing.Point(618, 223);
            this.textBEmail.Name = "textBEmail";
            this.textBEmail.Size = new System.Drawing.Size(135, 20);
            this.textBEmail.TabIndex = 24;
            // 
            // textBEstadoCivil
            // 
            this.textBEstadoCivil.Location = new System.Drawing.Point(618, 196);
            this.textBEstadoCivil.Name = "textBEstadoCivil";
            this.textBEstadoCivil.Size = new System.Drawing.Size(135, 20);
            this.textBEstadoCivil.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "[E-Mail]:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estado_Civil:";
            // 
            // textBProv_na
            // 
            this.textBProv_na.Location = new System.Drawing.Point(618, 353);
            this.textBProv_na.Name = "textBProv_na";
            this.textBProv_na.Size = new System.Drawing.Size(135, 20);
            this.textBProv_na.TabIndex = 33;
            // 
            // textBNacionalidad
            // 
            this.textBNacionalidad.Location = new System.Drawing.Point(618, 327);
            this.textBNacionalidad.Name = "textBNacionalidad";
            this.textBNacionalidad.Size = new System.Drawing.Size(135, 20);
            this.textBNacionalidad.TabIndex = 32;
            // 
            // textBFechaNac
            // 
            this.textBFechaNac.Location = new System.Drawing.Point(618, 300);
            this.textBFechaNac.Name = "textBFechaNac";
            this.textBFechaNac.Size = new System.Drawing.Size(135, 20);
            this.textBFechaNac.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(566, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "TelFijo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Nacionalidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(508, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Fecha_Nacimiento:";
            // 
            // textBTelFijo
            // 
            this.textBTelFijo.Location = new System.Drawing.Point(618, 274);
            this.textBTelFijo.Name = "textBTelFijo";
            this.textBTelFijo.Size = new System.Drawing.Size(135, 20);
            this.textBTelFijo.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(516, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Prov_Nacimiento:";
            // 
            // textBoxapelido
            // 
            this.textBoxapelido.Location = new System.Drawing.Point(619, 118);
            this.textBoxapelido.Name = "textBoxapelido";
            this.textBoxapelido.Size = new System.Drawing.Size(134, 20);
            this.textBoxapelido.TabIndex = 34;
            // 
            // txtboxDelete
            // 
            this.txtboxDelete.Location = new System.Drawing.Point(121, 339);
            this.txtboxDelete.Name = "txtboxDelete";
            this.txtboxDelete.Size = new System.Drawing.Size(240, 20);
            this.txtboxDelete.TabIndex = 35;
            this.txtboxDelete.Text = "http://localhost:53382/api/Personas/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.txtboxDelete);
            this.Controls.Add(this.textBoxapelido);
            this.Controls.Add(this.textBProv_na);
            this.Controls.Add(this.textBNacionalidad);
            this.Controls.Add(this.textBFechaNac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBTelFijo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBCelular);
            this.Controls.Add(this.textBEmail);
            this.Controls.Add(this.textBEstadoCivil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBSexo);
            this.Controls.Add(this.textBEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btput);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.txtbDNI);
            this.Controls.Add(this.txtbPersona_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxProvincia_Persona_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btPost);
            this.Controls.Add(this.textboxDatos);
            this.Controls.Add(this.btTraerDatos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btTraerDatos;
        private System.Windows.Forms.TextBox textboxDatos;
        private System.Windows.Forms.Button btPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtboxProvincia_Persona_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbPersona_id;
        private System.Windows.Forms.TextBox txtbDNI;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Button btput;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.TextBox textBSexo;
        private System.Windows.Forms.TextBox textBEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBCelular;
        private System.Windows.Forms.TextBox textBEmail;
        private System.Windows.Forms.TextBox textBEstadoCivil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBProv_na;
        private System.Windows.Forms.TextBox textBNacionalidad;
        private System.Windows.Forms.TextBox textBFechaNac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBTelFijo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxapelido;
        private System.Windows.Forms.TextBox txtboxDelete;
    }
}

