using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ContrasenyaValidatorTests
{
    // Casos de prova per longitud vàlida
    [TestMethod]
    [DataRow("abcdef", true)] // 6 caràcters
    [DataRow("abcdefghijklmno", true)] // 15 caràcters
    public void TestLongitudValida(string contrasenya, bool esperat)
    {
        bool resultat = ContrasenyaValidator.EsValida(contrasenya);
        Assert.AreEqual(esperat, resultat);
    }

    // Casos de prova per longitud invàlida
    [TestMethod]
    [DataRow("abc", false)] // menys de 6 caràcters
    [DataRow("abcdefghij1234567890", false)] // més de 15 caràcters
    public void TestLongitudInvalida(string contrasenya, bool esperat)
    {
        bool resultat = ContrasenyaValidator.EsValida(contrasenya);
        Assert.AreEqual(esperat, resultat);
    }

    // Casos de prova per caràcters invàlids
    [TestMethod]
    [DataRow("abc123!", false)] // conté caràcters especials
    [DataRow("abc 123", false)] // conté espais
    [DataRow("abc@123", false)] // conté símbols
    public void TestCaracteresInvalids(string contrasenya, bool esperat)
    {
        bool resultat = ContrasenyaValidator.EsValida(contrasenya);
        Assert.AreEqual(esperat, resultat);
    }

    // Casos de prova per inici o final amb números
    [TestMethod]
    [DataRow("1abcde", false)] // comença amb un número
    [DataRow("abcdef1", false)] // acaba amb un número
    public void TestIniciOFinalInvalida(string contrasenya, bool esperat)
    {
        bool resultat = ContrasenyaValidator.EsValida(contrasenya);
        Assert.AreEqual(esperat, resultat);
    }

    // Casos de prova per contrasenyes vàlides
    [TestMethod]
    [DataRow("abc123", true)] // 6 caràcters, lletres i números
    [DataRow("ABC123abc", true)] // 9 caràcters, lletres i números
    [DataRow("xYz123456", true)] // 9 caràcters, lletres i números
    public void TestContrasenyaValida(string contrasenya, bool esperat)
    {
        bool resultat = ContrasenyaValidator.EsValida(contrasenya);
        Assert.AreEqual(esperat, resultat);
    }
}
