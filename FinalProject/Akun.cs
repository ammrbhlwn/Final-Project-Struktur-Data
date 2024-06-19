using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

public class Akun
{
    public string username;
    private string _password;
    public string Password { get { return _password; } }

    public Akun(string username, string password)
    {
        this.username = username;
        this._password = password;
    }
}
