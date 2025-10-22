using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PaisesEstadosCidades
{
    class DaoEstados : Dao
    {
        public override string Excluir(object obj)
        {
            // Lógica de exclusão iria aqui (ou permanece como null/não implementada por enquanto)
            return null;
        }

        public override string Salvar(object obj)
        {
            Estados oestado = (Estados)obj;
            string msql = "";
            string mOk = "";

            try
            {
                using (SqlConnection cnn = Banco.Abrir())
                {
                    if (oestado.Codigo == 0) // Inserção
                    {
                        // CORREÇÃO ESSENCIAL: Omitimos "Id", "DatCad" e "UltAlt"
                        // O banco gera o ID e o "DatCad" (devido ao DEFAULT GETDATE())
                        msql = "INSERT INTO estados (estados, uf, idpais) " +
                               "VALUES (@Estados, @UF, @idpais)";
                    }
                    else // Atualização
                    {
                        // O UPDATE define UltAlt com a hora atual do banco
                        msql = "UPDATE estados SET estados=@Estados, uf=@UF, idpais=@idpais, " +
                               "UltAlt=GETDATE() WHERE id=@Codigo";
                    }

                    using (SqlCommand cmd = new SqlCommand(msql, cnn))
                    {
                        // Mapeamento de Parâmetros
                        cmd.Parameters.AddWithValue("@Estados", oestado.Estado);
                        cmd.Parameters.AddWithValue("@UF", oestado.Uf);
                        cmd.Parameters.AddWithValue("@idPais", oestado.Opais.Codigo);

                        // O parâmetro @Codigo é essencial para o UPDATE e é ignorado no INSERT
                        cmd.Parameters.AddWithValue("@Codigo", oestado.Codigo);

                        // 1. Executa o INSERT ou UPDATE
                        cmd.ExecuteNonQuery();

                        // 2. Captura o ID gerado (APENAS na Inserção)
                        if (oestado.Codigo == 0)
                        {
                            // Reutilizamos o "cmd" e a conexão para buscar o ID gerado (SCOPE_IDENTITY é o mais seguro)
                            cmd.CommandText = "SELECT SCOPE_IDENTITY()";

                            // ExecuteScalar retorna o ID gerado
                            object resultado = cmd.ExecuteScalar();

                            if (resultado != null && resultado != DBNull.Value)
                            {
                                // Converte e atribui o novo ID ao objeto
                                oestado.Codigo = Convert.ToInt32(resultado);
                                mOk = oestado.Codigo.ToString();
                            }
                            else
                            {
                                // Erro se o ID não for capturado
                                throw new InvalidOperationException("Falha ao obter o ID gerado após a inserção do Estado. Verifique a configuração IDENTITY da tabela.");
                            }
                        }
                        else
                        {
                            // Se for atualização, retorna o código existente
                            mOk = oestado.Codigo.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Incluído tratamento de erro robusto
                mOk = $"ERRO ao Salvar Estado: {ex.Message}";
                // Opcional: Você pode logar o erro aqui ou relançar a exceção.
            }

            return mOk;
        }

        public override object CarregaObj(int chave)
        {
            return null;
        }

        public override List<T> Pesquisar<T>(string chave)
        {
            return null;
        }
    }
}