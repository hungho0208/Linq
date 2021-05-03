using Dapper;
using DBModel.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            RCTPContractorContext context = new RCTPContractorContext();


            //最後練習題 dapper to linq 

            List<AdjustReprotDetailModel> listAdjustReprotDetailModel = new List<AdjustReprotDetailModel>();

            using (SqlConnection conn = new SqlConnection(context.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();

                string strSql = $@"SELECT c.Name AS PersonName,
                                   b.OldDate,
                                   s1.ShiftName AS OldShiftName,
                                   b.NewDate,
                                   s2.ShiftName AS NewShiftName,
                                   b.AdjustReason,
                                   b.AdjustType,
                                   b.LeaveHours,
                                   p.Name AS DelegateUserName
                            FROM dbo.AdjustScheduleMaster a
                                INNER JOIN dbo.AdjustScheduleDetail b
                                    ON a.ID = b.MasterId
                                INNER JOIN dbo.ContractPersonnel c
                                    ON b.PersonId = c.ID
                                LEFT JOIN dbo.Shift s1
                                    ON b.OldShiftId = s1.Id
                                LEFT JOIN dbo.Shift s2
                                    ON b.NewShiftId = s2.Id
                                LEFT JOIN dbo.ContractPersonnel p
                                    ON b.DelegateUserID = p.ID
                            WHERE a.ScheduleId = 8036
                                  AND a.Version = 2;";

                listAdjustReprotDetailModel = conn.Query<AdjustReprotDetailModel>(strSql).ToList();
            }

            if (listAdjustReprotDetailModel.Any())
            {
                Console.WriteLine("人員|異動類型|內容|異動原因");
                foreach (var item in listAdjustReprotDetailModel)
                {
                    Console.WriteLine($"{item.PersonName}|{item.AdjustType}| 日期: {item.OldDate.ToString("yyyy/MM/dd")}|{item.AdjustReason}");

                }
            }
            Console.ReadKey();
        }
    }

    public class AdjustReprotDetailModel
    {
        public int MasterId { get; set; }
        public string PersonName { get; set; }
        public string AdjustType { get; set; }
        public DateTime OldDate { get; set; }
        public DateTime NewDate { get; set; }
        public string OldShiftName { get; set; }
        public string NewShiftName { get; set; }
        public string AdjustReason { get; set; }
        public int? LeaveHours { get; set; }
        public string DelegateUserName { get; set; }
    }
}
