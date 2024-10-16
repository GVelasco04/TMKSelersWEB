using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppTelemarketing.Entidades
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UserId { get; set; }
       
        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { set; get; } //Propiedad automáticamente implemetada
        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "El formato de correo no es válido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        public string Clave { get; set; }
        [Column("IdTipoUsuario")]
        public int TipoUsuario { get; set; }
        [ForeignKey("TipoUsuario")]
        public TipoUsuarios TipoUsuariosNavigation { get; set; }

        public int AceptadoXAdmin { get; set; }


        public Usuario(string userName, string nombre, string apellido, string correo, string clave, int tipoUsuario, int aceptadoXAdmin)
        {

            UserName = userName;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Clave = clave;
            TipoUsuario = tipoUsuario;
            AceptadoXAdmin = aceptadoXAdmin;
        }

        // Constructor para inicializar cuando userId es necesario
        public Usuario(int userId, string userName, string nombre, string apellido, string correo, string clave, int tipoUsuario, int aceptadoXAdmin)
        {
            UserId = userId;
            UserName = userName;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Clave = clave;
            TipoUsuario = tipoUsuario;
            AceptadoXAdmin = aceptadoXAdmin;
        }

        public Usuario(int userId, string userName)
        {
            UserId = userId;
            UserName = userName;

        }
        public Usuario(int aceptadoXAdmin)
        {
            AceptadoXAdmin = aceptadoXAdmin;

        }

        public Usuario()
        {

        }
    }
}

