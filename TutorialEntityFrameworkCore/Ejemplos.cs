using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutorialEntityFrameworkCore.Models;

namespace TutorialEntityFrameworkCore
{
    class Ejemplos
    {
        static void GuardarEstudiantesDB()
        {
            
            SchoolDBContext context = new SchoolDBContext();
            try
            {
                var auxStudent = new Estudiantes()
                {
                    EstudianteId = 0,
                    Nombres = "Clarens",


                };
                context.Student.Add(auxStudent);
                bool save = context.SaveChanges() > 0;

                if (save)
                    Console.WriteLine("guadado Correctamente");
                else
                    Console.WriteLine("No Se Pudo Guardar");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

        }

        public static void GuardarCurso()
        {
           
            SchoolDBContext context = new SchoolDBContext();
            try
            {
                var auxCourse = new Cursos()
                {
                    CursoId = 0,
                    NombreCurso = "Sociales"

                };
                context.Courses.Add(auxCourse);
                bool save = context.SaveChanges() > 0;

                if (save)
                    Console.WriteLine("Guardado !!");
                else
                    Console.WriteLine("No se pudo Guardar");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                context.Dispose();
            }



        }


        public static void SimpleQueryDB()
        {
            
            const string NAME = "Michael";
            SchoolDBContext context = new SchoolDBContext();
            try
            {
                var list = context.Student.Where(s => s.Nombres == NAME).ToList();
                if (list != null)
                    Console.WriteLine(list.Find(s => s.Nombres == NAME).Nombres);
                else
                    Console.WriteLine("No se encuentra el Estudiante!!");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                context.Dispose();
            }
        }

        public static void DoubleQueryDB()
        {
            
           
            SchoolDBContext context = new SchoolDBContext();
            try
            {
                var resultado = context.Courses.Where(c => c.NombreCurso == "Sociales").FirstOrDefault();

                if (resultado != null)
                    Console.WriteLine(resultado.NombreCurso.ToString());
                else
                    Console.WriteLine("No se pudo Encontrar el Curso!!");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                context.Dispose();
            }

        }

        public static void QuerryUsingSql()
        {
            
            SchoolDBContext context = new SchoolDBContext();
            List<Estudiantes> studentList = new List<Estudiantes>();
            try
            {

                studentList = context.Student.FromSqlRaw("Select *from dbo.Students").ToList();
                if (studentList != null)
                    Console.WriteLine(studentList.Find(s => s.Nombres == "Bill").Nombres);
                else
                    Console.WriteLine("No se pudo Encontrar el Estudiante!!");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

        }

        public static void UpdatingData()
        {
            
            SchoolDBContext context = new SchoolDBContext();

            try
            {
                var std = context.Student.First<Estudiantes>();
                std.Nombres = "Mabel";
                bool modified = context.SaveChanges() > 0;

                if (modified)
                    Console.WriteLine("Modificado..");
                else
                    Console.WriteLine("No se pudo Modificar");

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }
        }

        public static void DeletingData()
        {
            
            SchoolDBContext context = new SchoolDBContext();

            try
            {
                var std = context.Student.First<Estudiantes>();
                context.Student.Remove(std);
                bool deleted = context.SaveChanges() > 0;

                if (deleted)
                    Console.WriteLine("Ha Sido Eliminado");
                else
                    Console.WriteLine("No se Pudo Eliminar Error");

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }
        }

        public static void UpdatingOnDisconnectedScenario()
        {
            SchoolDBContext context = new SchoolDBContext();
            try
            {
                var modifiedStudent1 = new Estudiantes()
                {
                    EstudianteId = 1,
                    Nombres = "Jay",

                };

                var modifiedStudent2 = new Estudiantes()
                {
                    EstudianteId = 2,
                    Nombres = "Juan",

                };

                List<Estudiantes> modifiedStudents = new List<Estudiantes>()
                {
                    modifiedStudent1,
                    modifiedStudent2,
                };

                context.UpdateRange(modifiedStudents);
                bool modified = context.SaveChanges() > 0;
                if (modified)
                    Console.WriteLine("Modificado");

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

        }
    }
}
  