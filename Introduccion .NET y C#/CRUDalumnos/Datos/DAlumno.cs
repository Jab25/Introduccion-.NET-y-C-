﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DAlumno
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Alumno> listAlumno;
        SqlCommand comando;

        public List<Alumno> consultar()
        {
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand("consultarTodos", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                listAlumno = new List<Alumno>();
                con.Close();
            }
            return listAlumno;
        }
        public Alumno consultar(int id)
        {
            Alumno alumno = new Alumno();
            
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand("consultarEAlumnos", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idRegistro", id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    alumno.id = reader.GetInt32(0);
                    alumno.nombre = reader.GetString(1);
                    alumno.primerApellido = reader.GetString(2);
                    alumno.segundoApellido = reader.GetString(3);
                    alumno.correo = reader.GetString(4);
                    alumno.telefono = reader.GetString(5);
                    alumno.fechaNacimiento = reader.GetDateTime(6);
                    alumno.curp = reader.GetString(7);
                    //alumno.sueldo = reader.GetString(8);
                    alumno.idEstadoOrigen = reader.GetInt32(8);
                    alumno.idEstatus = reader.GetInt16(9);
                }
                con.Close();
            }
            return alumno;
        }
        public void agregar(Alumno alumno)
        { 
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand("agregarAlumnos", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                comando.Parameters.AddWithValue("@nombre", alumno.nombre);
                comando.Parameters.AddWithValue("@primerApellido", alumno.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", alumno.segundoApellido);
                comando.Parameters.AddWithValue("@correo", alumno.correo);
                comando.Parameters.AddWithValue("@telefono", alumno.telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", alumno.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", alumno.curp);
                comando.Parameters.AddWithValue("@sueldo", alumno.sueldo);
                comando.Parameters.AddWithValue("@id_estado", alumno.idEstadoOrigen);
                comando.Parameters.AddWithValue("@id_estatus", alumno.idEstatus);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void actualizar(Alumno alumno)
        {
            using (SqlConnection conn = new SqlConnection(conection))
            {
                comando = new SqlCommand("actualizarAlumnos", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", alumno.id);
                conn.Open();
                comando.Parameters.AddWithValue("@nombre", alumno.nombre);
                comando.Parameters.AddWithValue("@primerApellido", alumno.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", alumno.segundoApellido);
                comando.Parameters.AddWithValue("@correo", alumno.correo);
                comando.Parameters.AddWithValue("@telefono", alumno.telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", alumno.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", alumno.curp);
                comando.Parameters.AddWithValue("@sueldo", alumno.sueldo);
                comando.Parameters.AddWithValue("@id_estado", alumno.idEstadoOrigen);
                comando.Parameters.AddWithValue("@id_estatus", alumno.idEstatus);
                comando.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand("eliminarAlumnos", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", id);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
