using UnityEngine;
using mvc.controller;
public class SQLCommandButtons : MonoBehaviour
{
    public SQLController sqlController;

    public void OnSelectButtonClick()
    {
        sqlController.AppendQuery("SELECT");
    }

    public void OnIncludeButtonClick()
    {
        sqlController.AppendQuery("INCLUDE");
    }

    public void OnWhereButtonClick()
    {
        sqlController.AppendQuery("WHERE");
    }

    public void OnAllButtonClick()
    {
        sqlController.AppendQuery("*");
    }

    public void OnFromButtonClick()
    {
        sqlController.AppendQuery("FROM");
    }

    public void OnPersediaanButtonClick()
    {
        sqlController.AppendQuery("Persediaan");
    }

    public void OnBarangButtonClick()
    {
        sqlController.AppendQuery("Barang");
    }
    public void OnAirButtonClick()
    {
        sqlController.AppendQuery("'Air'");
    }

    public void OnMakananButtonClick()
    {
        sqlController.AppendQuery("'Makanan'");
    }

    public void OnPenjelajahButtonClick()
    {
        sqlController.AppendQuery("Penjelajah");
    }

    public void OnTerakhirDipantauButtonClick()
    {
        sqlController.AppendQuery("Terakhir_dipantau");
    }

    public void OnGubukTuaButtonClick()
    {
        sqlController.AppendQuery("'Gubuk Tua'");
    }

    public void OnSemicolonButtonClick()
    {
        sqlController.AppendQuery(";");
    }

    public void OnEqualtoButtonClick()
    {
        sqlController.AppendQuery("=");
    }

    public void OnOnetoButtonClick()
    {
        sqlController.AppendQuery("1");
    }

    public void OnDescLimitButtonClick()
    {
        sqlController.AppendQuery("DESC LIMIT");
    }

    public void OnOrderByButtonClick()
    {
        sqlController.AppendQuery("ORDER BY");
    }

    public void OnLokasiButtonClick()
    {
        sqlController.AppendQuery("Lokasi");
    }

    public void OnKunjunganButtonClick()
    {
        sqlController.AppendQuery("Kunjungan");
    }

    public void OnBendaKunoButtonClick()
    {
        sqlController.AppendQuery("Benda_Kuno");
    }

    public void OnArtefakButtonClick()
    {
        sqlController.AppendQuery("Artefak");
    }

    public void OnPatungEmasButtonClick()
    {
        sqlController.AppendQuery("'Patung Emas'");
    }

    public void OnLikeButtonClick()
    {
        sqlController.AppendQuery("LIKE");
    }

    public void OnDescriptionButtonClick()
    {
        sqlController.AppendQuery("description");
    }

    public void OnmapButtonClick()
    {
        sqlController.AppendQuery("'%map%'");
    }

    public void OnReruntuhanButtonClick()
    {
        sqlController.AppendQuery("Reruntuhan");
    }

    public void OnSymbolButtonClick()
    {
        sqlController.AppendQuery("Symbol");
    }

    public void OnLingkaranButtonClick()
    {
        sqlController.AppendQuery("'Lingkaran'");
    }

    public void OnKunciKunciButtonClick()
    {
        sqlController.AppendQuery("Kunci-Kunci");
    }

    public void OnKunciButtonClick()
    {
        sqlController.AppendQuery("Kunci");
    }

    public void OnKunciEmasButtonClick()
    {
        sqlController.AppendQuery("'Kunci Emas'");
    }

    public void OnRuanganKuilButtonClick()
    {
        sqlController.AppendQuery("ruangan_kuil");
    }

    public void OnTerdapatButtonClick()
    {
        sqlController.AppendQuery("terdapat");
    }

    public void OnInstruksiKuilButtonClick()
    {
        sqlController.AppendQuery("instruksi_kuil");
    }

    public void OnLangkahKuilButtonClick()
    {
        sqlController.AppendQuery("langkah");
    }

    public void OnInputCodeKuilButtonClick()
    {
        sqlController.AppendQuery("'Inputkan Kode'");
    }

    public void OnJalanButtonClick()
    {
        sqlController.AppendQuery("Jalan");
    }

    public void OnPantaiButtonClick()
    {
        sqlController.AppendQuery("'pantai'");
    }

    public void OnMonumenButtonClick()
    {
        sqlController.AppendQuery("Monumen");
    }

    public void OnTypeButtonClick()
    {
        sqlController.AppendQuery("Type");
    }

    public void OnDestinasiButtonClick()
    {
        sqlController.AppendQuery("Destinasi");
    }

    public void OnairTerjunButtonClick()
    {
        sqlController.AppendQuery("'airTerjun'");
    }

    public void OnNamaButtonClick()
    {
        sqlController.AppendQuery("nama");
    }

    public void OnWargaDesaButtonClick()
    {
        sqlController.AppendQuery("WargaDesa");
    }

    public void OnAktivitasButtonClick()
    {
        sqlController.AppendQuery("aktivitas");
    }

    public void OnMengambilAirButtonClick()
    {
        sqlController.AppendQuery("'mengambil air'");
    }

    public void OnValuesAirButtonClick()
    {
        sqlController.AppendQuery("VALUES");
    }

    public void OnBuahIkanButtonClick()
    {
        sqlController.AppendQuery("('buah', 20), ('ikan', 5)");
    }

    public void OnIntoButtonClick()
    {
        sqlController.AppendQuery("INTO");
    }
    public void OnItemKuantitasButtonClick()
    {
        sqlController.AppendQuery("(item, kuantitas)");
    }

    public void OnInsertButtonClick()
    {
        sqlController.AppendQuery("INSERT");
    }

    public void OnHewanButtonClick()
    {
        sqlController.AppendQuery("hewan");
    }

    public void OnNamahewanButtonClick()
    {
        sqlController.AppendQuery("nama_hewan");
    }

    public void OnBabihutanButtonClick()
    {
        sqlController.AppendQuery("'babi hutan'");
    }

    public void OnUpdateButtonClick()
    {
        sqlController.AppendQuery("Update");
    }

    public void OnPerburuanButtonClick()
    {
        sqlController.AppendQuery("perburuan");
    }

    public void OnSetButtonClick()
    {
        sqlController.AppendQuery("SET");
    }

    public void OnStatusButtonClick()
    {
        sqlController.AppendQuery("status");
    }

    public void OnSelesaiButtonClick()
    {
        sqlController.AppendQuery("'selesai'");
    }

    public void OnHerbalButtonClick()
    {
        sqlController.AppendQuery("herbal");
    }


    public void OnTingkatButtonClick()
    {
        sqlController.AppendQuery("tingkat");
    }

    public void OnLangkaButtonClick()
    {
        sqlController.AppendQuery("'langka'");
    }

    public void OnHutanButtonClick()
    {
        sqlController.AppendQuery("hutan");
    }

    public void OnTumbuhanLangkaButtonClick()
    {
        sqlController.AppendQuery("'tumbuhan langka'");
    }

    public void OnDeleteButtonClick()
    {
        sqlController.AppendQuery("DELETE");
    }

    public void OnKonfirmasiButtonClick()
    {
        sqlController.AppendQuery("'konfirmasi'");
    }

    public void OnPilihanButtonClick()
    {
        sqlController.AppendQuery("Pilihan");
    }

    public void OnInButtonClick()
    {
        sqlController.AppendQuery("In");
    }

    public void OnMembangunPerahuButtonClick()
    {
        sqlController.AppendQuery("'membangun perahu'");
    }

    public void OnMemperbaikiDesaButtonClick()
    {
        sqlController.AppendQuery("'memperbaiki desa'");
    }

    public void OnMenjelajahiHutanButtonClick()
    {
        sqlController.AppendQuery("'menjelajahi hutan'");
    }

    public void OnKeputusanButtonClick()
    {
        sqlController.AppendQuery("keputusan");
    }

    public void OnTugasSelesaiButtonClick()
    {
        sqlController.AppendQuery("tugasSelesai");
    }

    public void OnTugasStatusButtonClick()
    {
        sqlController.AppendQuery("(tugas, status)");
    }

    public void OnMembangunPerahuSelesaiButtonClick()
    {
        sqlController.AppendQuery("('membangun perahu', 'selesai')");
    }
    public void OnMemperbaikiDesaSelesaiButtonClick()
    {
        sqlController.AppendQuery("('memperbaiki desa', 'selesai')");
    }
    public void OnMenjelajahiHutanSelesaiButtonClick()
    {
        sqlController.AppendQuery("('menjelajahi hutan', 'selesai')");
    }
    public void OnSumberDayaButtonClick()
    {
        sqlController.AppendQuery("sumberDaya");
    }

    public void OnTujuanButtonClick()
    {
        sqlController.AppendQuery("tujuan");
    }

    public void OnSiswaButtonClick()
    {
        sqlController.AppendQuery("siswa");
    }

    public void OnInsertSiswaButtonClick()
    {
        sqlController.AppendQuery("(4, 'Dede', 12)");
    }

    public void OnInsertSiswaColumnButtonClick()
    {
        sqlController.AppendQuery("(id, nama, umur)");
    }

    public void OnInsertSiswaWOColumnButtonClick()
    {
        sqlController.AppendQuery("id, nama, umur");
    }

    public void OnUmurButtonClick()
    {
        sqlController.AppendQuery("umur");
    }

    public void OnOneButtonClick()
    {
        sqlController.AppendQuery("1");
    }
    public void OnTenButtonClick()
    {
        sqlController.AppendQuery("10");
    }

    public void OnIDButtonClick()
    {
        sqlController.AppendQuery("id");
    }

    public void OnKaryawanButtonClick()
    {
        sqlController.AppendQuery("karyawan");
    }

    public void OnNamaCommaButtonClick()
    {
        sqlController.AppendQuery("nama,");
    }

    public void OnGajiButtonClick()
    {
        sqlController.AppendQuery("gaji");
    }

    public void OnGajiValueButtonClick()
    {
        sqlController.AppendQuery("> 50000");
    }

    public void OnDescButtonClick()
    {
        sqlController.AppendQuery("DESC");
    }

    public void OnSiswaLamaButtonClick()
    {
        sqlController.AppendQuery("siswa_lama");
    }

    public void OnSiswaBaruButtonClick()
    {
        sqlController.AppendQuery("siswa_baru");
    }

    public void OnpesananButtonClick()
    {
        sqlController.AppendQuery("pesanan");
    }

    public void OnTanggalpesananButtonClick()
    {
        sqlController.AppendQuery("tanggal_pesanan");
    }

    public void OnDiarsipkanButtonClick()
    {
        sqlController.AppendQuery("'Diarsipkan'");
    }

    public void OnFirstJanuaryButtonClick()
    {
        sqlController.AppendQuery("< '2022-01-01'");
    }

    public void OnIDPelangganButtonClick()
    {
        sqlController.AppendQuery("AND id_pelanggan > 100");
    }

}
