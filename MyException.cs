using System;
using System.Windows.Forms;


public class MyException : Exception
{
    DateTime m_errorTime;
    static ushort s_errorNumber;

    public MyException()
        : base("Message par défaut de l'exception.")
    {
        m_errorTime = DateTime.Now;
        s_errorNumber++;
    }

    public MyException(string message)
        : base(message)
    {
        m_errorTime = DateTime.Now;
        s_errorNumber++;
    }

    public void DisplayError()
    {
        MessageBox.Show(
            base.Message,
            string.Format(
                "Erreur n°{0} survenue à {1}.",
                s_errorNumber,
                m_errorTime.ToLongTimeString()),
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}