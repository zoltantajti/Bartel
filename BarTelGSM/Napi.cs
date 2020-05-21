using libsql;

namespace BarTelGSM
{
    public class Napi
    {
        MySQL db;

        public int nyito_kassza = 0;
        public int tetelszam = 0;
        public int tartozek_ar = 0;
        public int telefon_elad_db = 0;
        public int telefon_elad_ft = 0;
        public int telefon_vetel_db = 0;
        public int telefon_vetel_ft = 0;
        public int szerviz_db = 0;
        public int szerviz_ft = 0;
        public int kpki_db = 0;
        public int kpki = 0;

        public int kassza = 0;

        public bool checkNapi()
        {
            db = new MySQL();
            if (db.count("napi_jelentes", "id", "WHERE bolt='" + Program.bolt + "' AND datum=CURRENT_DATE") == 0)
            {
                return false;
            }
            else return true;
        }
        public void makeNapi()
        {
            string values = "bolt='" + Program.bolt + "',datum=CURRENT_DATE," +
                "nyito_kassza = '" + nyito_kassza + "', tartozek_db='" + tetelszam + "'," +
                "tartozek_ft='" + tartozek_ar + "', telefon_elad_db='" + telefon_elad_db + "'," +
                "telefon_elad_ft='" + telefon_elad_ft + "',telefon_vetel_db='" + telefon_vetel_db + "'," +
                "telefon_vetel_ft='" + telefon_vetel_ft + "',szerviz_db='" + szerviz_db + "'," +
                "szerviz_ft='" + szerviz_ft + "',kpki_db='" + kpki_db + "',kpki_ft='" + kpki + "'," +
                "kassza='" + kassza + "'";
            db.insert("napi_jelentes", values);
        }
        public void updateNapi()
        {
            string values = "bolt='" + Program.bolt + "'," +
                "tartozek_db='" + tetelszam + "'," +
                "tartozek_ft='" + tartozek_ar + "', telefon_elad_db='" + telefon_elad_db + "'," +
                "telefon_elad_ft='" + telefon_elad_ft + "',telefon_vetel_db='" + telefon_vetel_db + "'," +
                "telefon_vetel_ft='" + telefon_vetel_ft + "',szerviz_db='" + szerviz_db + "'," +
                "szerviz_ft='" + szerviz_ft + "',kpki_db='" + kpki_db + "',kpki_ft='" + kpki + "'," +
                "kassza='" + kassza + "'";
            string where = "WHERE bolt='" + Program.bolt + "' AND datum=CURRENT_DATE";
            db.update("napi_jelentes", values, where);
        }
        public void napiFrissit()
        {
            if (this.checkNapi() == true)
            {
                updateNapi();
            }
            else makeNapi();
        }
    }
}
