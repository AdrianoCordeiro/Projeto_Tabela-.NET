using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Lição_10_18112020
{
    public partial class frmLicao1018112020 : Form
    {

        StreamReader objLeitor;
        string strLinhaLida, strValorAntigo;

        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataReader objleitorDb;
        OleDbDataAdapter objAdaptador;
        DataTable objTabela;

        public frmLicao1018112020()
        {
            InitializeComponent();
        }

              private void btnDesvCondEnc_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Escolha uma opção", "Desvio Condicoanl Encadeado", MessageBoxButtons.YesNoCancel);
            if (Result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Você escolhei Sim!");
            }
            else if (Result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Você escolhei Não!");
            }
            else
            {
                MessageBox.Show("Você escolhei Cancelar!");
            }

        }

              private void btnImportTxtWhile_Click(object sender, EventArgs e)
              {
                  ImportaTxtWhile();
              }
              public void ImportaTxtWhile()
              {
                  objLeitor = new StreamReader(@"C:\Automação bancaria\Preferencias.txt");
                  strLinhaLida = objLeitor.ReadLine();

                  while (strLinhaLida != null)
                  {
                      lstbxPreferencias.Items.Add(strLinhaLida);
                      strLinhaLida = objLeitor.ReadLine();
                  }

                  objLeitor.Close();

              }

              private void btnImportBdConec_Click(object sender, EventArgs e)
              {
                  ImportBdConec();
              }
              public void ImportBdConec()
              {
                  objConexao = new OleDbConnection();
                  objConexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Automação bancaria\Preferencias.accdb";
                  objConexao.Open();

                  objComando = new OleDbCommand();
                  objComando.Connection = objConexao;
                  objComando.CommandText = "SELECT Descricao FROM Preferencias_3";

                  objleitorDb = objComando.ExecuteReader();

                  while (objleitorDb.Read())
                  {
                      lstbxPreferencias.Items.Add(objleitorDb["Descricao"].ToString());
                  }

                  objConexao.Close();
              
              }

              private void btnImprtBdDesc_Click(object sender, EventArgs e)
              {
                  ImportBdDesconec();
              }
              public void ImportBdDesconec()
              {
                  objConexao = new OleDbConnection();
                  objConexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Automação bancaria\Preferencias.accdb";
                  objConexao.Open();

                  objComando = new OleDbCommand();
                  objComando.Connection = objConexao;
                  objComando.CommandText = "SELECT Descricao FROM Preferencias_3";

                  objAdaptador = new OleDbDataAdapter();
                  objAdaptador.SelectCommand = objComando;

                  objTabela = new DataTable();
                  objAdaptador.Fill(objTabela);
                  foreach (DataRow objLinhadaTabela in objTabela.Rows)
                  {
                      lstbxPreferencias.Items.Add(objLinhadaTabela["Descricao"].ToString());
                  }

              }

              private void btnConsultBd_Click(object sender, EventArgs e)
              {
                  ConsultBd();
              }
              public void ConsultBd()
              {
                  objConexao = new OleDbConnection();
                  objConexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Automação bancaria\Preferencias.accdb";
                  objConexao.Open();

                  objComando = new OleDbCommand();
                  objComando.Connection = objConexao;
                  objComando.CommandText = "SELECT Descricao FROM Preferencias_3";

                  objAdaptador = new OleDbDataAdapter();
                  objAdaptador.SelectCommand = objComando;

                  objTabela = new DataTable();
                  objAdaptador.Fill(objTabela);

                  bndsrcPreferencias.DataSource = objTabela;
                  dtgdvwPreferencias.DataSource = bndsrcPreferencias;

              }

              private void btnIncluirBd_Click(object sender, EventArgs e)
              {
                  IncluirBd();
              }
              public void IncluirBd()
              {
                  objConexao = new OleDbConnection();
                  objConexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Automação bancaria\Preferencias.accdb";
                  objConexao.Open();

                  objComando = new OleDbCommand();
                  objComando.Connection = objConexao;
                  objComando.CommandText = "INSERT INTO Preferencias_3(Descricao) VALUES ('" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "')";

                  if (objComando.ExecuteNonQuery() > 0)
                  {
                      MessageBox.Show("Registro Incluso!");
                  }
                  else
                  {
                      MessageBox.Show("Registro Não Incluso!");
                  }

                  objConexao.Close();
              }

              private void btnExcluirBd_Click(object sender, EventArgs e)
              {
                  ExcluirBd();
              }
              public void ExcluirBd()
              {
                  objConexao = new OleDbConnection();
                  objConexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Automação bancaria\Preferencias.accdb";
                  objConexao.Open();

                  objComando = new OleDbCommand();
                  objComando.Connection = objConexao;
                  objComando.CommandText = "DELETE FROM Preferencias_3 WHERE Descricao ='" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "'";

                  if (objComando.ExecuteNonQuery() > 0)
                  {
                      MessageBox.Show("Registro Excluido");
                  }
                  else
                  {
                      MessageBox.Show("Registro Excluido");
                  }

                  objConexao.Close();
              
              }

              private void btnAlterarBd_Click(object sender, EventArgs e)
              {
                  AlterarBd();
              }
              public void AlterarBd()
              { 
                  objConexao = new OleDbConnection();
                  objConexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Automação bancaria\Preferencias.accdb";
                  objConexao.Open();

                  objComando = new OleDbCommand();
                  objComando.Connection = objConexao;
                  objComando.CommandText = "UPDATE Preferencias_3 SET Descricao = '" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() +
                                                             "' WHERE Descricao = '" + strValorAntigo + "'";
                  if (objComando.ExecuteNonQuery() > 0)
                  {
                      MessageBox.Show("Registro Alterado");
                  }
                  else
                  {
                      MessageBox.Show("Registro não Alterado");
                  }

                  objConexao.Close();

              }

              private void frmLicao1018112020_Load(object sender, EventArgs e)
              {
                  ConsultBd();
              }

              private void dtgdvwPreferencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
              {
                  strValorAntigo = dtgdvwPreferencias.CurrentCell.Value.ToString();
              }
    }
}
