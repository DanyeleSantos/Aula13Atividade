namespace Aula13Atividade
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas= new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }

        public void atualizaInterface() 
        {
            listView1.Clear();
            for (int i = 0; i < pessoas.Count; i++)
            {
                listView1.Items.Add(pessoas[i].nome);

            }
        
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            int idade = int.Parse( txtidade.Text);
            string rua = txtrua.Text;
            string cidade = txtcidade.Text;

            Pessoa pessoa = new Pessoa(nome, idade, rua, cidade);
            pessoas.Add(pessoa);
            atualizaInterface();

        }

        private void txtendereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}