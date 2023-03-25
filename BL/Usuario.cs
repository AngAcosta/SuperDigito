using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.SuperDigitoContext context = new DL.SuperDigitoContext())
                {

                    int query = context.Database.ExecuteSqlRaw($"UsuarioAddSp '{usuario.UserName}','{usuario.Password}'");

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se Inserto el Ususario";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Message = ex.Message;
            }
            return result;
        }
        public static ML.Result UsuarioGetbyUserName(string UserName)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.SuperDigitoContext context = new DL.SuperDigitoContext())
                {
                    var query = context.Usuarios.FromSqlRaw($"UsuarioGetByUserName '{UserName}'").AsEnumerable().FirstOrDefault();

                    if (query != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();

                        usuario.IdUsuario = query.IdUsuario;
                        usuario.UserName = query.UserName;
                        usuario.Password = query.Password;


                        result.Object = usuario;
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = true;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}