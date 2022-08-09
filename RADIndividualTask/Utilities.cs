using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RADIndividualTask.Models1;

namespace RADIndividualTask
{
    public static class Utilities
    {
        public static double CountUnits(this Material material, out List<InputReport> reports)
        {
            reports = CRUD.Context.InputReports.ToList().Where(item => item.MaterialId == material.Id).ToList();

            if (reports.Count == 0) return 0d;
            return reports.Sum(report => report.Units);
        }

        public static bool IsInRange(this DateTime date, DateTime a, DateTime b)
        {
            return date > a && date < b;
        }
    }
}