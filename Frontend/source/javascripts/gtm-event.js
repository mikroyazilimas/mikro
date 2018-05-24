$(function () {

    var iletisimJsonData = [
        { "https://www.mikro.com.tr/iletisim/bize-ulasin": "iletisimFormu_bize-ulasim" },
        { "https://www.mikro.com.tr/": "iletisimFormu_ana-sayfa" }
    ]


    var ussJsonData = [
        { "https://www.mikro.com.tr/": "urunSecmeSihirbazı_ana-sayfa" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-run/": "urunSecmeSihirbazı_run" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-run/e-donusum-cozumleri": "urunSecmeSihirbazı_run" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-run/satis-ve-musteri-yonetimi": "urunSecmeSihirbazı_run" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-run/gider-ve-parasal-hareketlerin-yonetimi": "urunSecmeSihirbazı_run" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-run/satinalma-ve-tedarikci-yonetimi": "urunSecmeSihirbazı_run" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-run/stok-urun-ve-hizmet-yonetimi": "urunSecmeSihirbazı_run" }
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-jump/": "urunSecmeSihirbazı_jump" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-jump/ana-paket": "urunSecmeSihirbazı_jump" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-jump/e-donusum-cozumleri": "urunSecmeSihirbazı_jump" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-jump/isletme-yonetimi-cozumleri": "urunSecmeSihirbazı_jump" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-jump/sektorel-cozumler": "urunSecmeSihirbazı_jump" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-jump/entegrasyon-cozumleri": "urunSecmeSihirbazı_jump" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-fly/": "urunSecmeSihirbazı_fly" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-fly/ana-paket": "urunSecmeSihirbazı_fly" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-fly/e-donusum-cozumleri": "urunSecmeSihirbazı_fly" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-fly/isletme-yonetimi-cozumleri": "urunSecmeSihirbazı_fly" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-fly/sektorel-cozumler": "urunSecmeSihirbazı_fly" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-fly/entegrasyon-cozumleri": "urunSecmeSihirbazı_fly" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-musavir": "urunSecmeSihirbazı_mikro-usvir" }
    ]


    var demoTalepJsonData = [
        { "https://www.mikro.com.tr/e-donusum/e-fatura": "demoTalebi_e-fatura" },
        { "https://www.mikro.com.tr/e-donusum/e-arsiv": "demoTalebi_e-arsiv" },
        { "https://www.mikro.com.tr/e-donusum/e-defter": "demoTalebi_e-defter" },
        { "https://www.mikro.com.tr/e-donusum/e-bordro": "demoTalebi_e-bordro" },
        { "https://www.mikro.com.tr/e-donusum/e-mutabakat": "demoTalebi_e-mutabakat" },
        { "https://www.mikro.com.tr/e-donusum/mikro-kep": "demoTalebi_mikro-kep" },
        { "https://www.mikro.com.tr/e-donusum/e-irsaliye": "demoTalebi_e-irsaliye" },
        { "https://www.mikro.com.tr/e-donusum/e-mustahsil-makbuzu": "demoTalebi_e-mustahsil-makbuzu" },
        { "https://www.mikro.com.tr/e-donusum/e-serbest-meslek-makbuzu": "demoTalebi_e-serbest-meslek-makbuzu" },
        { "https://www.mikro.com.tr/ucretsiz-demo-talep?product=RUN": "demoTalebi_run" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-run/": "demoTalebi_run" },
        { "https://www.mikro.com.tr/ucretsiz-demo-talep?product=JUMP": "demoTalebi_jump" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-jump/": "demoTalebi_jump" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/genel-bakis": "demoTalebi_fly" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-fly/": "demoTalebi_fly" },
        { "https://www.mikro.com.tr/ucretsiz-demo-talep?product=MUSAVIR": "demoTalebi_musavir" },
        { "https://www.mikro.com.tr/urunler-ve-hizmetler/mikro-musavir": "demoTalebi_musavir" },
        { "https://www.mikro.com.tr/": "demoTalebi_ana-sayfa" }
    ]

})