namespace Socios_CamaraC
{
    public class Socio
    {
        public int NumSocio { get; set; }
        public string Apellido { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string? DNI { get; set; }
        public string Sexo { get; set; } = "M";
        public DateTime? FechaNacimiento { get; set; }
        public string? NumTelefono { get; set; }
        public string? CalleNombre { get; set; }
        public int? CalleNum { get; set; }
        public string? Localidad { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int CategoriaId { get; set; }
        public bool EstaActivo { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";
        public string FechaNacimientoStr =>
            FechaNacimiento?.ToString("dd/MM/yyyy") ?? "";
        public string Direccion
        {
            get
            {
                if (string.IsNullOrWhiteSpace(CalleNombre) && !CalleNum.HasValue)
                    return string.Empty;

                if (string.IsNullOrWhiteSpace(CalleNombre))
                    return CalleNum.ToString()!;

                if (!CalleNum.HasValue)
                    return CalleNombre;

                return $"{CalleNombre} {CalleNum}";
            }
        }
        public string FechaAltaStr =>
            FechaAlta?.ToString("dd/MM/yyyy") ?? "";

    }
}
