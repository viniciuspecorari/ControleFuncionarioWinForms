using ControleFuncionario.Contracts;
using ControleFuncionario.Presenter;

namespace ControleFuncionario.View
{
    public partial class ControleFuncionario : Form, IControleFuncionario
    {
        private readonly IFuncionarioPresenter _presenter;

        public ControleFuncionario(IFuncionarioPresenter presenter)
        {
            InitializeComponent(); 
            _presenter = presenter;      
            _presenter.SetView(this);

            textName.Text = "";
        }       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _presenter.CadastrarFuncionario();

            var bindingSource = new BindingSource();
            dataGridViewFuncionarios.DataSource = bindingSource;

            bindingSource.DataSource = _presenter.RecuperarFuncionarios();

            if (dataGridViewFuncionarios.Columns["Id"] is not null) dataGridViewFuncionarios.Columns["Id"].Visible = false;

        }


        // Properties
        public string Name
        {
            get => textName.Text;
            set => textName.Text = value;
        }

        public DateTime DateOfBirth
        {
            get => Convert.ToDateTime(textDataNascimento.Text);
            set => textDataNascimento.Text = value.ToString("dd/mm/yyyy");
        }

        public string Function
        {
            get => textFunction.Text;
            set => textFunction.Text = value;
        }

    }
}
