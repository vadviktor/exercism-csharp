using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var s = new List<string>();

        if (id != null) s.Add($"[{id}]");
        s.Add(name);
        s.Add(department == null ? "OWNER" : department.ToUpper());

        return String.Join(" - ", s);
    }
}
