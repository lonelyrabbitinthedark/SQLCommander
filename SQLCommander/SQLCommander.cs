using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SQLCommander
{
    public abstract class SqlCommander
    {
        private string _libraryVersion = "0.0.0.0";
        private string _libraryAuthor = "Alex";

        public string LibraryVersion
        {
            get { return _libraryVersion; }
        }

        public string LibraryAuthor
        {
            get { return _libraryAuthor; }
        }
    }
}
