using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteSchool.DataBase.Tables
{
    class Note
    {
        //Table data
        private static String tableName = "tNote";

        //Table atributes
        private static String tIdNote = "idNote";
        private static String tSubject = "subject";
        private static String tTitle = "title";
        private static String tBody = "body";
        
        //Table funcion
        private static String IF_TABLE_EXISTS = "IF object_id ('" + tableName + "') IS NULL ";

        public static String CREATE_TABLE_NOTE = IF_TABLE_EXISTS + "CREATE TABLE " + tableName + "(" +
            tIdNote + " INTEGER PRIMARY KEY NOT NULL, " +
            tSubject + " VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES " + Subject.tableName + "(" + Subject.tName + "), " +
            tTitle + " VARCHAR(150) NOT NULL, " +
            tBody + " TEXT);";
    
    }
}
