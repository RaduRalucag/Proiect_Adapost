﻿namespace Proiect_Adapost.Models.Oras.DTO
{
    public class OrasResponseDto
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public IEnumerable<string> NumeAdaposturi { get; set; }
    }
}
