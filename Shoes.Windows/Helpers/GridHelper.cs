using Shoes.Entidades;
using Shoes.Entidades.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Color = Shoes.Entidades.Color;

namespace Shoes.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }

        public static void QuitarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Remove(r);
        }
        public static void SetearFila(DataGridViewRow r, object item)
        {
            switch (item)
            {
                case Color color:
                    r.Cells[0].Value = color.ColorName;
                    break;
            }
            switch (item)
            {
                case Brand brand:
                    r.Cells[0].Value = brand.BrandName;
                    break;
            }
            switch (item)
            {
                case Genre genre:
                    r.Cells[0].Value = genre.GnereName;
                    break;
            }
            switch (item)
            {
                case Sport sport:
                    r.Cells[0].Value = sport.SportName;
                    break;
            }
            switch (item)
            {
                case ShoeListDto shoe:
                    r.Cells[0].Value = shoe.Model;
                    r.Cells[1].Value = shoe.Description;
                    r.Cells[2].Value = shoe.Price;
                    r.Cells[3].Value = shoe.ColorN;
                    r.Cells[4].Value = shoe.Genre;
                    r.Cells[5].Value = shoe.Brand;
                    r.Cells[6].Value = shoe.Sport;
                    break;
            }
            switch (item)
            {
                case Color color:
                    r.Cells[0].Value = color.ColorName;
                    break;
            }
            r.Tag = item;
        }

        public static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }
    }
}
