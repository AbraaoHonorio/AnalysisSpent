using System;

namespace AnalysisSpent.Domain.Invoice
{
    public class Invoice
    {
        public DateTime Date { get; private set; }
        public string Describe { get; private set; }
        public decimal Value { get; private set; }
        public string Category { get; private set; }

        public Invoice SetData(string data)
        {
            Date = DateTime.Parse(data);
            return this;
        }

        public Invoice SetDescricao(string descricao)
        {
            Describe = descricao;
            return this;
        }

        public Invoice SetValor(string valor)
        {
            Value = Convert.ToDecimal(valor);
            return this;
        }

        public Invoice SetCategoria(string categoria)
        {
            Category = categoria;
            return this;
        }

        public override string ToString()
        {
            return $"Data Descricao Valor Categoria" +
                   $"{Date} {Describe} {Value} {Category}";
        }
    }
}