using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class UploadedDocument
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string FileName { get; set; } = string.Empty;

        public string FilePath { get; set; } = string.Empty;

        public string OCRText { get; set; } = string.Empty;

        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        public Customer Customer { get; set; }
    }
}
