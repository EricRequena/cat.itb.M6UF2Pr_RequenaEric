using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;
using cat.itb.M6UF2Pr_RequenaEric.model;
namespace cat.itb.M6UF2Pr_RequenaEric.cruds;

public class GeneralCrud
{
    public static void DropTables(List<string> tables)
    {
        using (var conn = new CloudConnection().GetConnection())
        {
            foreach (var table in tables)
            {
                var cmd = new NpgsqlCommand("DROP TABLE IF EXISTS " + table + " CASCADE", conn);

                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table {0} successfully dropped", table);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error dropping table {table}: {ex.Message}");
                }
            }
        }
    }

    public static void RunScriptShop()
    {
        using (var conn = new CloudConnection().GetConnection())
        {
            try
            {
                string script = File.ReadAllText("../../../fitxers/shop.sql");
                var cmd = new NpgsqlCommand(script, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Script executed successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing script: {ex.Message}");
            }
        }
    }
}
