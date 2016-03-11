using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bl_res_styles
{
    public static class bl_helper
    {
        public static int[,] Kindexes = {{0,-1,1,2,3,4,5,6,int.MaxValue},
                                        {0,-1,1,2,3,4,5,7,int.MaxValue},
                                        {0,-1,1,2,3,4,8,9,int.MaxValue},
                                        {0,-1,1,2,3,4,10,11,12},
                                        {0,-1,1,2,3,4,13,14,int.MaxValue},
                                        {0,-1,1,2,3,4,15,16,int.MaxValue},
                                        {0,-1,1,2,3,4,17,18,int.MaxValue}
                                        };
        public static string[] Knames = { "Коэффициент маневренности", 
                                   "Коэффициент автономии", 
                                   "Коэффициент клиентской базы", 
                                   "Коэффициент общей ликвидности", 
                                   "Коэффициент эффективности использования активов", 
                                   "Коэффициент качества ссудной задолженности", 
                                   "Коэффициент покрытия процентов" 
                                 };
        public delegate void U_del(int row, DataGridView table);

        public static U_del[] Kfunctions = {
                             delegate(int row,DataGridView table)
                             {
                                      table.Rows[row].Cells[1].Value = Math.Round((
                                      Convert.ToSingle(table.Rows[row].Cells[6].Value) - 
                                      Convert.ToSingle(table.Rows[row].Cells[7].Value)) / 
                                      Convert.ToSingle(table.Rows[row].Cells[6].Value),4);
                             },
                             delegate(int row,DataGridView table)
                             {
                                     table.Rows[row].Cells[1].Value = Math.Round(
                                     Convert.ToSingle(table.Rows[row].Cells[6].Value) / 
                                     Convert.ToSingle(table.Rows[row].Cells[7].Value),4); 
                             },
                             delegate(int row,DataGridView table)
                             {
                                     table.Rows[row].Cells[1].Value = Math.Round(
                                     Convert.ToSingle(table.Rows[row].Cells[6].Value)/
                                     (Convert.ToSingle(table.Rows[row].Cells[7].Value)- 
                                     Convert.ToSingle(table.Rows[row].Cells[8].Value)),4);
                             }
                         };
        public static int[] Kfunc_indexes = { 0, 1, 1, 2, 1, 1, 1 };
    }
}
