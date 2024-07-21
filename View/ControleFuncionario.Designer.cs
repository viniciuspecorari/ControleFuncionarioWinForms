namespace ControleFuncionario.View
{
    partial class ControleFuncionario
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
            textDataNascimento = new MaskedTextBox();
            textName = new TextBox();
            textFunction = new TextBox();
            labelName = new Label();
            labelDateOfBirth = new Label();
            labelFunction = new Label();
            buttonSave = new Button();
            dataGridViewFuncionarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // textDataNascimento
            // 
            textDataNascimento.Location = new Point(152, 68);
            textDataNascimento.Mask = "00/00/0000";
            textDataNascimento.Name = "textDataNascimento";
            textDataNascimento.Size = new Size(151, 23);
            textDataNascimento.TabIndex = 2;
            textDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // textName
            // 
            textName.Location = new Point(12, 68);
            textName.Name = "textName";
            textName.Size = new Size(134, 23);
            textName.TabIndex = 1;
            // 
            // textFunction
            // 
            textFunction.Location = new Point(309, 68);
            textFunction.Name = "textFunction";
            textFunction.Size = new Size(130, 23);
            textFunction.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 50);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 3;
            labelName.Text = "Name:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(152, 50);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(117, 15);
            labelDateOfBirth.TabIndex = 4;
            labelDateOfBirth.Text = "Data de Nascimento:";
            // 
            // labelFunction
            // 
            labelFunction.AutoSize = true;
            labelFunction.Location = new Point(309, 50);
            labelFunction.Name = "labelFunction";
            labelFunction.Size = new Size(49, 15);
            labelFunction.TabIndex = 5;
            labelFunction.Text = "Função:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(445, 58);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(95, 41);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Cadastrar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Dock = DockStyle.Bottom;
            dataGridViewFuncionarios.Location = new Point(0, 115);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.Size = new Size(566, 358);
            dataGridViewFuncionarios.TabIndex = 7;
            // 
            // ControleFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 473);
            Controls.Add(dataGridViewFuncionarios);
            Controls.Add(buttonSave);
            Controls.Add(labelFunction);
            Controls.Add(labelDateOfBirth);
            Controls.Add(labelName);
            Controls.Add(textFunction);
            Controls.Add(textName);
            Controls.Add(textDataNascimento);
            Name = "ControleFuncionario";
            Text = "Funcionários";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox textDataNascimento;
        private TextBox textName;
        private TextBox textFunction;
        private Label labelName;
        private Label labelDateOfBirth;
        private Label labelFunction;
        private Button buttonSave;
        private DataGridView dataGridViewFuncionarios;
    }
}