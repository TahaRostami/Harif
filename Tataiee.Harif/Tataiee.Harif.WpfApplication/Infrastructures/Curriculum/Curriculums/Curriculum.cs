using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tataiee.Harif.Infrastructures.Curriculum.Constraints;
using Tataiee.Harif.Infrastructures.GeneralEnums;
using Tataiee.Harif.Infrastructures.Curriculum;
using Tataiee.Harif.Infrastructures.Curriculum.Curriculums;
using Tataiee.Harif.Infrastructures.Data.Curriculum;

namespace Tataiee.Harif.Infrastructures.Curriculum.Curriculums
{
    public class MainCurriculum
    {
        //Curriculum_ComputerEngineering92

        private const int credit_gerayesh_mohandesi_computer = 101;
        private const int credit_gerayeshe_narmafzar = 102;
        private const int credit_gerayeshe_memarie_system_haye_computeri = 103;
        private const int credit_gerayeshe_rayaneshe_amn = 104;
        private const int credit_gerayeshe_fanavarie_ettelaat = 105;

        private const int credit_tamrkoze_NA_MOSHAKAS = 121;
        private const int credit_tamrkoze_system_haye_mojtama = 122;
        private const int credit_tamrkoze_shabake_haye_computer = 123;
        private const int credit_tamrkoze_hooshe_masnooie = 124;
        private const int credit_tamrkoze_system_haye_narmafzari = 125;
        private const int credit_tamrkoze_algorithm_va_mohasebat = 126;
        private const int credit_tamrkoze_bazi_haye_computeri = 127;
        private const int credit_tamrkoze_system_haye_ettelaati = 128;
        private const int credit_tamrkoze_amniate_rayaneh = 129;

        private const int DefaultCurriculumValue = 101;
        private const int DefaultSpecializedFocusValue = 121;



        #region Courses

        public Course AndisheEslami1 { get; private set; }
        public Course AndisheEslami2 { get; private set; }
        public Course EnsanDarEslam { get; private set; }
        public Course HoghoogheEjtemaiVaSiasiDarEslam { get; private set; }
        public Course FalsafeAkhlagh { get; private set; }
        public Course AkhlagheEslami_mabaniVaMafahim { get; private set; }
        public Course AieeneZendegi { get; private set; }
        public Course ErfaneAmalieEslami { get; private set; }
        public Course EnghelabeEslamieIran { get; private set; }
        public Course AshenaieeBaGhanooneAsasieJomhoorieEslamieIran { get; private set; }
        public Course AndisheSiasieAmamKhomeyni { get; private set; }
        public Course TarikheFarhangVaTamadoneEslami { get; private set; }
        public Course TarikheTahlilieSadreEslam { get; private set; }
        public Course TarikheEmamat { get; private set; }
        public Course TafsireMozooieGhoran { get; private set; }
        public Course TafsireMozooieNahjolBalagheh { get; private set; }
        public Course ZabaneFarsi { get; private set; }
        public Course ZabaneEnglish { get; private set; }
        public Course TarbiatBadanieYek { get; private set; }
        public Course TarbiatBadanieDo { get; private set; }
        public Course DaneshKhanevadeVaJamiat { get; private set; }
        public Course RiaziOmoomieYek { get; private set; }
        public Course RiaziOmoomieDo { get; private set; }
        public Course FizikeYek { get; private set; }
        public Course FizikeDo { get; private set; }
        public Course AmaroEhtemaleMohandesi { get; private set; }
        public Course MoadelateDifransiel { get; private set; }
        public Course KargaheComputer { get; private set; }
        public Course AzmayeshgaheFizikDo { get; private set; }
        public Course MabanieComputerVaBarnameSazi { get; private set; }
        public Course MadarHayeElectrici { get; private set; }
        public Course RiaziateGosasteh { get; private set; }
        public Course BarnameSaziePishrafteh { get; private set; }
        public Course SakhtemanHayeDadeh { get; private set; }
        public Course MadarHayeManteghi { get; private set; }
        public Course NazarieZabanHaVaMashinHa { get; private set; }
        public Course ZabaneTakhasosi { get; private set; }
        public Course RaveshePajoosheshVaEraeh { get; private set; }
        public Course RiaziateMohandesi { get; private set; }
        public Course MemarieComputer { get; private set; }
        public Course SystemHayeAmel { get; private set; }
        public Course TarahieAlgorithmHa { get; private set; }
        public Course TarahieCopmuterieSystemHayeDigital { get; private set; }
        public Course SignalhaVaSystemHa { get; private set; }
        public Course RizPardazandehVaZabanehAssemblie { get; private set; }
        public Course ShabakeHayeComputeri { get; private set; }
        public Course HoosheMasnooiVaSystemHayeKhebreh { get; private set; }
        public Course OsooleTarahieCompiler { get; private set; }
        public Course AzmayeshgaheSystemHayeAmel { get; private set; }
        public Course AzmayeshgaheMadarHayeManteghiVaMemarieComputer { get; private set; }
        public Course AzmayeshgaheRizpardazandeh { get; private set; }
        public Course AzmayeshgaheShabakeHayeComputeri { get; private set; }
        public Course MadarHayeElectronici { get; private set; }
        public Course ElectroniceDigital { get; private set; }
        public Course EnteghaleDadeha { get; private set; }
        public Course SystemHayeControleKhati { get; private set; }
        public Course AzmayeshgaheMadarhayeElectronici { get; private set; }
        public Course AzmayeshgaheElectroniceDigital { get; private set; }
        public Course AzmayeshgaheAbzarHayeTarrahiBaKomakeComputer { get; private set; }
        public Course KarAmoozieMemari { get; private set; }
        public Course ProjecteMemarieComputer { get; private set; }
        public Course TahliloTarrahieSystemHa { get; private set; }
        public Course PaygaheDadeHa { get; private set; }
        public Course TarrahieZabanHayeBarnameNevisi { get; private set; }
        public Course MohandesieNarmafzar { get; private set; }
        public Course MohandesieInternet { get; private set; }
        public Course KarAmoozieNarmafzar { get; private set; }
        public Course ProjectNarmafzar { get; private set; }
        public Course AmniateShabake { get; private set; }
        public Course MabanieRayanesheAmn { get; private set; }
        public Course AmniateSystemHayePaye { get; private set; }
        public Course ModiriateAmniateEttelaat { get; private set; }
        public Course MabanieRamznegari { get; private set; }
        public Course ToseeAmneNarmafzar { get; private set; }
        public Course HoghooghoAdeleElectroniciDarAmniat { get; private set; }
        public Course KarAmoozieRayanesheAmn { get; private set; }
        public Course ProjectRayanesheAmn { get; private set; }//
        public Course OsooleFanavarieEttelaat { get; private set; }
        public Course OsooleModiratoVaBarnameRizieRahbordieFanavarieEttelaat { get; private set; }
        public Course ModiriateProjectHayeFanavarieEttelaat { get; private set; }
        public Course YekparcheSazieKarbordHayeSazmani { get; private set; }
        public Course EghtesadeMohandesi { get; private set; }
        public Course TejarateElectronici { get; private set; }
        public Course KarAmoozieFanavarieEttelaat { get; private set; }
        public Course ProjecteFanavarieEttelaat { get; private set; }
        public Course HamTarrahieSakhtafzar_Narmafzar { get; private set; }
        public Course SystemHayeNahoftehVaBiderang { get; private set; }
        public Course TarahieSystemHayeMojtamaePorTarakom { get; private set; }
        public Course MemarieShetabdahandehHayeSheygera { get; private set; }
        public Course TarahieMadarHayeVaset { get; private set; }
        public Course TarahieMadarHayeDigitaleFerekansBala { get; private set; }
        public Course MabanieShabakeHayeBisim { get; private set; }
        public Course MabanieHoosheMohasebati { get; private set; }
        public Course MabanieBinaieeComputer { get; private set; }
        public Course MabaniePardazesheZabanVaGoftar { get; private set; }
        public Course OsooleRobatic { get; private set; }
        public Course TaamoleEnsanVaComputer { get; private set; }
        public Course AzmooneNarmafzar { get; private set; }
        public Course RaveshHayeRasmiDarMohandesiNarmafzar { get; private set; }
        public Course TarahieSheygerayeSystemHa { get; private set; }
        public Course NazarieVaAlgorithmHayeGraph { get; private set; }
        public Course NazarieMohasebat { get; private set; }
        public Course MabaineNazarieBaziHa { get; private set; }
        public Course AlgorithmHayePishrafte { get; private set; }
        public Course MoghadameiBarMosabeghateBarnameNevisi { get; private set; }
        public Course ManteghDarOloomVaMohandesieComputer { get; private set; }
        public Course SystemHayeChandResanie { get; private set; }
        public Course TarahieBaziHayeComputeri { get; private set; }
        public Course GraphiceComputeri { get; private set; }
        public Course MabaniePooyanamaieeComputeri { get; private set; }
        public Course PiadeSazieSystemePaygaheDadeh { get; private set; }
        public Course MabanieDadeKavi { get; private set; }
        public Course MabanieBazyabieEttelaatVaJostojooyeWeb { get; private set; }
        public Course SystemHayeEttelaateModiriat { get; private set; }
        public Course YekDarsAzKarshenasieArshadeReshteMohandesieComputer1 { get; private set; }
        public Course MabaheseVijeh1 { get; private set; }
        public Course MabaheseVijeh2 { get; private set; }
        public Course YekDarsAzDoreKarshenasieReshteHayeDigar1 { get; private set; }
        public Course NemooneSazieSystemHayePichideSakhtafzariNarmafzari { get; private set; }
        public Course MoghadameiBarElmeAsab { get; private set; }
        public Course AzmayeshgaheMohandesieNarmafzar { get; private set; }
        public Course AzmayeshgaheOsooleTarrahieCompiler { get; private set; }
        public Course AzmayeshgahePaygaheDadeh { get; private set; }
        public Course AzmayeshgaheMadarHayeElectrici { get; private set; }
        public Course AzmayeshgaheMadarHayeVaset { get; private set; }
        public Course AzmayeshgaheOsooleRobatic { get; private set; }
        public Course AzmayeshgaheGraphiceComputeri { get; private set; }
        public Course AzmayeshgaheBaziHayeComputeri { get; private set; }
        public Course AzmayeshgaheVagheiateMajazi { get; private set; }
        public Course AzmayeshgaheAmniateShabakeh { get; private set; }
        public Course KargaheSakhteRobot { get; private set; }
        public Course KargaheBarnamehnevisieMatlab { get; private set; }
        public Course AzmayeshgaheAutomationeSanati { get; private set; }
        public Course AzmayeshgaheSystemHayeControlKhati { get; private set; }
        public Course SystemHayeAutomationeSanati { get; private set; }
        public Course OloomoMaarefeDefaeMoghadas { get; private set; }
        public Course YekDarsAzKarshenasieArshadeReshteMohandesieComputer2 { get; private set; }
        public Course YekDarsAzKarshenasieArshadeReshteMohandesieComputer3 { get; private set; }
        public Course YekDarsAzDoreKarshenasieReshteHayeDigar2 { get; private set; }
        public Course YekDarsAzDoreKarshenasieReshteHayeDigar3 { get; private set; }
        #endregion

        #region Course Categories
        public CourseCategory Root { get; private set; }
        public CourseCategory DorooseOmoomiVaMaaref { get; private set; }
        public CourseCategory DarsHayePaye { get; private set; }
        public CourseCategory DarsHayeAsli { get; private set; }
        public CourseCategory DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer { get; private set; }
        public CourseCategory DarsHayeTamarkozHayeEkhtiari { get; private set; }
        public CourseCategory DarsHayeEkhtiari { get; private set; }
        public CourseCategory DarseEkhtiariAzArshadeComputer { get; private set; }
        public CourseCategory DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar { get; private set; }
        public CourseCategory TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer { get; private set; }
        public CourseCategory BasteMakhsooseNarmafzarBareTakhasosieShabake { get; private set; }
        public CourseCategory BasteMakhsooseSakhtAfzarBareTakhasosieShabake { get; private set; }
        public CourseCategory KhateTire_dorooseOmoomiVaMaaref { get; private set; }
        public CourseCategory KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri { get; private set; }
        public CourseCategory MabanieNazarieEslam { get; private set; }
        public CourseCategory AkhlagheEslami { get; private set; }
        public CourseCategory EnghelabeEslami { get; private set; }
        public CourseCategory TarikhOtamadoneEslami { get; private set; }
        public CourseCategory AshnaieBaManabeEslami { get; private set; }
        public CourseCategory DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri { get; private set; }
        public CourseCategory DarsHayeTakhasosieGerayesheNarmafzar { get; private set; }
        public CourseCategory DarsHayeTakhasosieGerayesheRayanesheAmn { get; private set; }
        public CourseCategory DarsHayeTakhasosieGerayesheFanavarieEttelaat { get; private set; }
        public CourseCategory DarsHayeTamarkozTakhassosieSystemHayeMojtama { get; private set; }
        public CourseCategory DarsHayeTamarkozTakhassosieShabakeHayeComputeri { get; private set; }
        public CourseCategory KhateTire_darsHayeEkhtiari { get; private set; }
        public CourseCategory DarsHayeTamarkozTakhassosieHoosheMasnooi { get; private set; }
        public CourseCategory DarsHayeTamarkozTakhassosieSystemHayeNarmafzari { get; private set; }
        public CourseCategory DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat { get; private set; }
        public CourseCategory DarsHayeTamarkozTakhassosieBaziHayeComputeri { get; private set; }
        public CourseCategory DarsHayeTamarkozTakhassosieSystemHayeEttelaati { get; private set; }
        public CourseCategory DarsHayeTamarkozTakhassosieAmniateRayaneh { get; private set; }

        #endregion

        #region Gates
        public Gate Gate_root_dorooseOmoomiVaMaaref { get; private set; }
        public Gate Gate_root_darsHayePaye { get; private set; }
        public Gate Gate_root_darsHayeAsli { get; private set; }
        public Gate Gate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer { get; private set; }
        public Gate Gate_root_darsHayeTamarkozHayeEkhtiari { get; private set; }
        public Gate Gate_root_darsHayeEkhtiari { get; private set; }
        public Gate Gate_dorooseOmoomiVaMaaref_mabanieNazarieEslam { get; private set; }
        public Gate Gate_dorooseOmoomiVaMaaref_akhlagheEslami { get; private set; }
        public Gate Gate_dorooseOmoomiVaMaaref_enghelabeEslami { get; private set; }
        public Gate Gate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami { get; private set; }
        public Gate Gate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami { get; private set; }
        public Gate Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri { get; private set; }
        public Gate Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar { get; private set; }
        public Gate Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn { get; private set; }
        public Gate Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat { get; private set; }
        public Gate Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama { get; private set; }
        public Gate Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri { get; private set; }
        public Gate Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi { get; private set; }
        public Gate Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari { get; private set; }
        public Gate Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat { get; private set; }
        public Gate Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri { get; private set; }
        public Gate Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati { get; private set; }
        public Gate Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh { get; private set; }
        public Gate Gate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer { get; private set; }
        public Gate Gate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar { get; private set; }
        public Gate Gate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer { get; private set; }
        public Gate Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake { get; private set; }
        public Gate Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati { get; private set; }
        public Gate Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh { get; private set; }
        public Gate Gate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref { get; private set; }
        public Gate Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri { get; private set; }
        public Gate Gate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari { get; private set; }
        #endregion

        #region CreditCard92
        public CreditCard92 Credit1 { get; private set; }
        public CreditCard92 Credit2 { get; private set; }
        public CreditCard92 Credit3 { get; private set; }
        public CreditCard92 Credit4 { get; private set; }
        public CreditCard92 Credit5 { get; private set; }
        public CreditCard92 Credit6 { get; private set; }
        public CreditCard92 Credit7 { get; private set; }
        public CreditCard92 Credit8 { get; private set; }
        public CreditCard92 Credit9 { get; private set; }
        public CreditCard92 Credit10 { get; private set; }
        public CreditCard92 Credit11 { get; private set; }
        public CreditCard92 Credit12 { get; private set; }
        public CreditCard92 Credit13 { get; private set; }
        public CreditCard92 Credit14 { get; private set; }
        public CreditCard92 Credit15 { get; private set; }
        public CreditCard92 Credit16 { get; private set; }
        public CreditCard92 Credit17 { get; private set; }
        public CreditCard92 Credit18 { get; private set; }
        public CreditCard92 Credit19 { get; private set; }
        public CreditCard92 Credit20 { get; private set; }
        public CreditCard92 Credit21 { get; private set; }
        public CreditCard92 Credit22 { get; private set; }
        public CreditCard92 Credit23 { get; private set; }
        public CreditCard92 Credit24 { get; private set; }
        public CreditCard92 Credit25 { get; private set; }
        public CreditCard92 Credit26 { get; private set; }
        public CreditCard92 Credit27 { get; private set; }
        public CreditCard92 Credit28 { get; private set; }
        public CreditCard92 Credit29 { get; private set; }
        #endregion

        #region Constraints

        public MinNumberMaxNumberOfCoursesConstraint Constraint1 { get; private set; }
        public MinNumberMaxNumberOfCoursesConstraint Constraint2 { get; private set; }
        public MinNumberMaxNumberOfCoursesConstraint Constraint3 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint4 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint5 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint6 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint7 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint8 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint9 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint10 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint11 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint12 { get; private set; }
        public NumberOfCoursesMustBeLabOrWorkshopConstraint Constraint13 { get; private set; }
        public NumberOfCoursesMustBeLabOrWorkshopConstraint Constraint14 { get; private set; }
        public MinNumberMaxNumberOfCoursesConstraint Constraint15 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint16 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint17 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint18 { get; private set; }
        public MinNumberMaxNumberOfCoursesConstraint Constraint19 { get; private set; }
        public MinUnitsMaxUnitsOfCoursesConstraint Constraint20 { get; private set; }
        public UnitOfCoursesMustBeLabOrWorkshopConstraint Constraint21 { get; private set; }
        #endregion        


        public List<SatelliteInformation> CreateNewSatelliteInformationList()
        {
            List<SatelliteInformation> satLst = new List<SatelliteInformation>();
            for (int i = 0; i < CourseCategories.Count; i++)
            {
                satLst.Add(new SatelliteInformation() { Id = CourseCategories[i].Id });//i
            }
            return satLst;
        }

        #region main
        public List<CourseCategory> CourseCategories { get; private set; } = new List<CourseCategory>();

        public List<Gate> Gates { get; private set; } = new List<Gate>();

        public List<Course> Courses { get; private set; } = new List<Course>();

        public List<ICreditCard> CreditCards { get; private set; } = new List<ICreditCard>();

        public List<Certificate> Certificates { get; private set; } = new List<Certificate>();

        public List<Constraint> Constraints { get; private set; } = new List<Constraint>();


        public CreditCard92 StudentCredit { get; private set; }

        public MainCurriculum() : this(null) { }

        public MainCurriculum(ICreditCard credit)
        {
            if (credit == null)
            {
                StudentCredit = (CreditCard92)CreateStudentCredit(DefaultCurriculumValue, DefaultSpecializedFocusValue);
            }
            else if (credit is CreditCard92)
            {
                CreditCard92 crt = (CreditCard92)credit;
                StudentCredit = (CreditCard92)CreateStudentCredit(crt.CurriculumList[0], crt.SpecializedFocus[0]);
            }
            else throw new ArgumentException();

            InitLoad();
            ModifyData();
        }

        private void ModifyData()
        {
            int curr = StudentCredit.CurriculumList[0];
            int spc = StudentCredit.SpecializedFocus[0];

            #region enteghal dadeh
            if (curr == credit_gerayeshe_narmafzar || curr == credit_gerayeshe_fanavarie_ettelaat || curr == credit_gerayeshe_rayaneshe_amn)
            {
                if (curr == credit_gerayeshe_narmafzar)
                {
                    EnteghaleDadeha.CourseCategories.Remove(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
                    DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Remove(EnteghaleDadeha);
                }
                else
                {
                    EnteghaleDadeha.CourseCategories.Remove(BasteMakhsooseNarmafzarBareTakhasosieShabake);
                    BasteMakhsooseNarmafzarBareTakhasosieShabake.Courses.Remove(EnteghaleDadeha);
                }

            }
            #endregion

            #region Tahli o Tarrahi

            if (curr == credit_gerayeshe_memarie_system_haye_computeri)
            {
                TahliloTarrahieSystemHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(TahliloTarrahieSystemHa);

                TahliloTarrahieSystemHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(TahliloTarrahieSystemHa);
            }
            else if (curr == credit_gerayeshe_narmafzar)
            {
                TahliloTarrahieSystemHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(TahliloTarrahieSystemHa);

                TahliloTarrahieSystemHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(TahliloTarrahieSystemHa);
            }
            else if (curr == credit_gerayeshe_rayaneshe_amn)
            {
                TahliloTarrahieSystemHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(TahliloTarrahieSystemHa);

                TahliloTarrahieSystemHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(TahliloTarrahieSystemHa);
            }
            else if (curr == credit_gerayeshe_fanavarie_ettelaat)
            {
                TahliloTarrahieSystemHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(TahliloTarrahieSystemHa);

                TahliloTarrahieSystemHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(TahliloTarrahieSystemHa);
            }
            #endregion

            #region Payghae dade ha
            if (curr == credit_gerayeshe_memarie_system_haye_computeri)
            {
                PaygaheDadeHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(PaygaheDadeHa);

                PaygaheDadeHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(PaygaheDadeHa);
            }
            else if (curr == credit_gerayeshe_narmafzar)
            {
                PaygaheDadeHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(PaygaheDadeHa);

                PaygaheDadeHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(PaygaheDadeHa);
            }
            else if (curr == credit_gerayeshe_rayaneshe_amn)
            {
                PaygaheDadeHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(PaygaheDadeHa);

                PaygaheDadeHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(PaygaheDadeHa);
            }
            else if (curr == credit_gerayeshe_fanavarie_ettelaat)
            {
                PaygaheDadeHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(PaygaheDadeHa);

                PaygaheDadeHa.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(PaygaheDadeHa);

                PaygaheDadeHa.PrerequisiteCourses.Clear();
                PaygaheDadeHa.PrerequisiteCourses.Add(TahliloTarrahieSystemHa);                

            }
            #endregion

            #region Mohandesi e Internet
            if (curr == credit_gerayeshe_memarie_system_haye_computeri || curr == credit_gerayeshe_fanavarie_ettelaat || curr == credit_gerayeshe_rayaneshe_amn)
            {
                if (curr == credit_gerayeshe_memarie_system_haye_computeri)
                {
                    MohandesieInternet.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                    DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(MohandesieInternet);
                }
                else
                {
                    MohandesieInternet.CourseCategories.Remove(BasteMakhsooseSakhtAfzarBareTakhasosieShabake);
                    BasteMakhsooseSakhtAfzarBareTakhasosieShabake.Courses.Remove(MohandesieInternet);
                }

            }
            #endregion

            #region Amniat e Shabake

            if (curr == credit_gerayeshe_rayaneshe_amn)
            {
                AmniateShabake.CourseCategories.Remove(KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);
                KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri.Courses.Remove(AmniateShabake);


                AmniateShabake.CourseCategories.Remove(DarsHayeTamarkozTakhassosieAmniateRayaneh);
                DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Remove(AmniateShabake);
            }
            else if (spc == credit_tamrkoze_amniate_rayaneh)
            {
                AmniateShabake.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(AmniateShabake);

                AmniateShabake.CourseCategories.Remove(KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);
                KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri.Courses.Remove(AmniateShabake);

            }
            else if (spc != credit_tamrkoze_NA_MOSHAKAS)
            {

                AmniateShabake.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(AmniateShabake);

                AmniateShabake.CourseCategories.Remove(DarsHayeTamarkozTakhassosieAmniateRayaneh);
                DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Remove(AmniateShabake);

            }
            #endregion

            #region Mabanie Rayanesh e Amn

            if (curr == credit_gerayeshe_rayaneshe_amn)
            {
                MabanieRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(MabanieRayanesheAmn);

                MabanieRayanesheAmn.CourseCategories.Remove(DarsHayeTamarkozTakhassosieAmniateRayaneh);
                DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Remove(MabanieRayanesheAmn);
            }
            else if (curr == credit_gerayeshe_fanavarie_ettelaat)
            {
                MabanieRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(MabanieRayanesheAmn);

                MabanieRayanesheAmn.CourseCategories.Remove(DarsHayeTamarkozTakhassosieAmniateRayaneh);
                DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Remove(MabanieRayanesheAmn);

                MabanieRayanesheAmn.PrerequisiteCourses.Clear();
                MabanieRayanesheAmn.RequisiteCourses.Clear();
                MabanieRayanesheAmn.PrerequisiteCourses.Add(ShabakeHayeComputeri);

            }
            else if (spc == credit_tamrkoze_amniate_rayaneh)
            {
                MabanieRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(MabanieRayanesheAmn);

                MabanieRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(MabanieRayanesheAmn);

                MabanieRayanesheAmn.PrerequisiteCourses.Clear();
                MabanieRayanesheAmn.RequisiteCourses.Clear();

            }
            else if (spc == credit_tamrkoze_NA_MOSHAKAS)
            {
                MabanieRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(MabanieRayanesheAmn);

            }
            else
            {
                MabanieRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(MabanieRayanesheAmn);

                MabanieRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(MabanieRayanesheAmn);
            }

            #endregion

            #region Amniate System haye paye

            if (curr == credit_gerayeshe_rayaneshe_amn)
            {
                AmniateSystemHayePaye.CourseCategories.Remove(DarsHayeTamarkozTakhassosieAmniateRayaneh);
                DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Remove(AmniateSystemHayePaye);
            }
            else if (spc == credit_tamrkoze_amniate_rayaneh)
            {
                AmniateSystemHayePaye.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(AmniateSystemHayePaye);
            }
            else if(spc== credit_tamrkoze_NA_MOSHAKAS || curr == credit_gerayesh_mohandesi_computer)
            {
                if(curr == credit_gerayesh_mohandesi_computer)
                {
                    AmniateSystemHayePaye.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                    DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(AmniateSystemHayePaye);
                }
                else//curr == credit tamarkoz na moshakhas
                {
                    AmniateSystemHayePaye.CourseCategories.Remove(DarsHayeTamarkozTakhassosieAmniateRayaneh);
                    DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Remove(AmniateSystemHayePaye);
                }
                
            }
            else
            {
                AmniateSystemHayePaye.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(AmniateSystemHayePaye);
            }

            #endregion

            #region Modiriate Amniate Ettelaat
            if (curr == credit_gerayeshe_rayaneshe_amn)
            {
                ModiriateAmniateEttelaat.CourseCategories.Remove(DarsHayeTamarkozTakhassosieAmniateRayaneh);
                DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Remove(ModiriateAmniateEttelaat);
            }
            else if (spc == credit_tamrkoze_amniate_rayaneh)
            {
                ModiriateAmniateEttelaat.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(ModiriateAmniateEttelaat);
            }
            else
            {
                ModiriateAmniateEttelaat.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(ModiriateAmniateEttelaat);

            }

            #endregion

            #region System Haye Nahofte o biderang

            if (spc == credit_tamrkoze_shabake_haye_computer)
            {
                SystemHayeNahoftehVaBiderang.CourseCategories.Remove(DarsHayeTamarkozTakhassosieSystemHayeMojtama);
                DarsHayeTamarkozTakhassosieSystemHayeMojtama.Courses.Remove(SystemHayeNahoftehVaBiderang);
            }
            else if (spc == credit_tamrkoze_system_haye_mojtama)
            {
                //fire course
                SystemHayeNahoftehVaBiderang.CourseCategories.Remove(KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);
                KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri.Courses.Remove(SystemHayeNahoftehVaBiderang);
            }
            else
            {
                SystemHayeNahoftehVaBiderang.CourseCategories.Remove(KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);
                KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri.Courses.Remove(SystemHayeNahoftehVaBiderang);
            }
            #endregion


            #region Karamoozi Ha & Prj Ha

            if (curr == credit_gerayeshe_narmafzar)
            {
                KarAmoozieMemari.CourseCategories.Remove(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
                DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Remove(KarAmoozieMemari);

                ProjecteMemarieComputer.CourseCategories.Remove(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
                DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Remove(ProjecteMemarieComputer);
                //--------------------------

                KarAmoozieRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(KarAmoozieRayanesheAmn);

                ProjectRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(ProjectRayanesheAmn);

                //-------------------------

                KarAmoozieFanavarieEttelaat.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(KarAmoozieFanavarieEttelaat);

                ProjecteFanavarieEttelaat.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(ProjecteFanavarieEttelaat);

                //-------------------------

            }
            else if (curr == credit_gerayeshe_memarie_system_haye_computeri)
            {
                KarAmoozieNarmafzar.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(KarAmoozieNarmafzar);

                ProjectNarmafzar.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(ProjectNarmafzar);
                //--------------------------


                KarAmoozieRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(KarAmoozieRayanesheAmn);

                ProjectRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(ProjectRayanesheAmn);

                //-------------------------

                KarAmoozieFanavarieEttelaat.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(KarAmoozieFanavarieEttelaat);

                ProjecteFanavarieEttelaat.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(ProjecteFanavarieEttelaat);

                //-------------------------
            }
            else if (curr == credit_gerayeshe_fanavarie_ettelaat)
            {
                KarAmoozieMemari.CourseCategories.Remove(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
                DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Remove(KarAmoozieMemari);

                ProjecteMemarieComputer.CourseCategories.Remove(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
                DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Remove(ProjecteMemarieComputer);

                //--------------------------

                KarAmoozieNarmafzar.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(KarAmoozieNarmafzar);

                ProjectNarmafzar.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(ProjectNarmafzar);
                //--------------------------


                KarAmoozieRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(KarAmoozieRayanesheAmn);

                ProjectRayanesheAmn.CourseCategories.Remove(DarsHayeTakhasosieGerayesheRayanesheAmn);
                DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Remove(ProjectRayanesheAmn);

                //-------------------------
            }
            else if(curr == credit_gerayeshe_rayaneshe_amn)
            {
                KarAmoozieMemari.CourseCategories.Remove(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
                DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Remove(KarAmoozieMemari);

                ProjecteMemarieComputer.CourseCategories.Remove(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
                DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Remove(ProjecteMemarieComputer);

                //--------------------------

                KarAmoozieNarmafzar.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(KarAmoozieNarmafzar);

                ProjectNarmafzar.CourseCategories.Remove(DarsHayeTakhasosieGerayesheNarmafzar);
                DarsHayeTakhasosieGerayesheNarmafzar.Courses.Remove(ProjectNarmafzar);
                //--------------------------
                KarAmoozieFanavarieEttelaat.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(KarAmoozieFanavarieEttelaat);

                ProjecteFanavarieEttelaat.CourseCategories.Remove(DarsHayeTakhasosieGerayesheFanavarieEttelaat);
                DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Remove(ProjecteFanavarieEttelaat);

                //-------------------------
            }

            #endregion

        }

        public static ICreditCard CreateStudentCredit(int curr, int spc)
        {
            var crt = new CreditCard92 { Id = int.MaxValue };
            crt.CurriculumList.Add(curr);
            crt.SpecializedFocus.Add(spc);
            return crt;
        }

        private void InitLoad()
        {
            int i = 0;

            #region  CourseCategory
            #region 1
            //ست کردن Id برای CourseCategoryHa
            //حذف و ایجاد فیلد متناظر

            Root = new CourseCategory { Title = "ریشه", };
            CourseCategories.Add(Root);//0
            Root = CourseCategories[i++];

            DorooseOmoomiVaMaaref = new CourseCategory { Title = "دروس عمومی و معارف", };
            CourseCategories.Add(DorooseOmoomiVaMaaref);//1
            DorooseOmoomiVaMaaref = CourseCategories[i++];

            DarsHayePaye = new CourseCategory { Title = "درسهای پایه", };
            CourseCategories.Add(DarsHayePaye);//2
            DarsHayePaye = CourseCategories[i++];

            DarsHayeAsli = new CourseCategory { Title = "درسهای اصلی", };
            CourseCategories.Add(DarsHayeAsli);//3
            DarsHayeAsli = CourseCategories[i++];

            DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer = new CourseCategory { Title = "درسهای تخصصی گرایش های چهارگانه رشته مهندسی کامپیوتر", };
            CourseCategories.Add(DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer);//4
            DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer = CourseCategories[i++];

            DarsHayeTamarkozHayeEkhtiari = new CourseCategory { Title = "درسهای تمرکز های تخصصی اختیاری", };
            CourseCategories.Add(DarsHayeTamarkozHayeEkhtiari);//5
            DarsHayeTamarkozHayeEkhtiari = CourseCategories[i++];

            DarsHayeEkhtiari = new CourseCategory { Title = "درسهای اختیاری", };
            CourseCategories.Add(DarsHayeEkhtiari);//6
            DarsHayeEkhtiari = CourseCategories[i++];

            //----------
            //Strat Subset


            MabanieNazarieEslam = new CourseCategory { Title = "مبانی نظری اسلام", };
            CourseCategories.Add(MabanieNazarieEslam);//7
            MabanieNazarieEslam = CourseCategories[i++];

            AkhlagheEslami = new CourseCategory { Title = "اخلاق اسلامی", };
            CourseCategories.Add(AkhlagheEslami);//8
            AkhlagheEslami = CourseCategories[i++];

            EnghelabeEslami = new CourseCategory { Title = "انقلاب اسلامی", };
            CourseCategories.Add(EnghelabeEslami);//9
            EnghelabeEslami = CourseCategories[i++];

            TarikhOtamadoneEslami = new CourseCategory { Title = "تاریخ و تمدن اسلامی", };
            CourseCategories.Add(TarikhOtamadoneEslami);//10
            TarikhOtamadoneEslami = CourseCategories[i++];

            AshnaieBaManabeEslami = new CourseCategory { Title = "آشنایی با منابع اسلامی", };
            CourseCategories.Add(AshnaieBaManabeEslami);//11
            AshnaieBaManabeEslami = CourseCategories[i++];

            //--------------------------------

            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri = new CourseCategory { Title = "درسهای تخصصی گرایش معماری سیستم های کامپیوتری", };
            CourseCategories.Add(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);//12
            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri = CourseCategories[i++];

            DarsHayeTakhasosieGerayesheNarmafzar = new CourseCategory { Title = "درسهای تخصصی گرایش نرم افزار", };
            CourseCategories.Add(DarsHayeTakhasosieGerayesheNarmafzar);//13
            DarsHayeTakhasosieGerayesheNarmafzar = CourseCategories[i++];

            DarsHayeTakhasosieGerayesheRayanesheAmn = new CourseCategory { Title = "درسهای تخصصی گرایش رایانش امن", };
            CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);//14
            DarsHayeTakhasosieGerayesheRayanesheAmn = CourseCategories[i++];

            DarsHayeTakhasosieGerayesheFanavarieEttelaat = new CourseCategory { Title = "درسهای تخصصی گرایش فناوری اطلاعات", };
            CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);//15
            DarsHayeTakhasosieGerayesheFanavarieEttelaat = CourseCategories[i++];

            //---------------------------------

            DarsHayeTamarkozTakhassosieSystemHayeMojtama = new CourseCategory { Title = "درسهای تمرکز تخصصی سیستم های مجتمع", };
            CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeMojtama);//16
            DarsHayeTamarkozTakhassosieSystemHayeMojtama = CourseCategories[i++];

            DarsHayeTamarkozTakhassosieShabakeHayeComputeri = new CourseCategory { Title = "درسهای تمرکز تخصصی شبکه های کامپیوتری", };
            CourseCategories.Add(DarsHayeTamarkozTakhassosieShabakeHayeComputeri);//17
            DarsHayeTamarkozTakhassosieShabakeHayeComputeri = CourseCategories[i++];

            DarsHayeTamarkozTakhassosieHoosheMasnooi = new CourseCategory { Title = "درسهای تمرکز تخصصی هوش مصنوعی", };
            CourseCategories.Add(DarsHayeTamarkozTakhassosieHoosheMasnooi);//18
            DarsHayeTamarkozTakhassosieHoosheMasnooi = CourseCategories[i++];

            DarsHayeTamarkozTakhassosieSystemHayeNarmafzari = new CourseCategory { Title = "درسهای تمرکز تخصصی سیستم های نرم افزاری", };
            CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeNarmafzari);//19
            DarsHayeTamarkozTakhassosieSystemHayeNarmafzari = CourseCategories[i++];

            DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat = new CourseCategory { Title = "درسهای تمرکز تخصصی الگوریتم و محاسبات", };
            CourseCategories.Add(DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat);//20
            DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat = CourseCategories[i++];

            DarsHayeTamarkozTakhassosieBaziHayeComputeri = new CourseCategory { Title = "درسهای تمرکز تخصصی بازی های کامپیوتری", };
            CourseCategories.Add(DarsHayeTamarkozTakhassosieBaziHayeComputeri);//21
            DarsHayeTamarkozTakhassosieBaziHayeComputeri = CourseCategories[i++];

            DarsHayeTamarkozTakhassosieSystemHayeEttelaati = new CourseCategory { Title = "درسهای تمرکز تخصصی سیستم های اطلاعاتی", };
            CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeEttelaati);//22
            DarsHayeTamarkozTakhassosieSystemHayeEttelaati = CourseCategories[i++];

            DarsHayeTamarkozTakhassosieAmniateRayaneh = new CourseCategory { Title = "درسهای تمرکز تخصصی امنیت رایانه", };
            CourseCategories.Add(DarsHayeTamarkozTakhassosieAmniateRayaneh);//23
            DarsHayeTamarkozTakhassosieAmniateRayaneh = CourseCategories[i++];

            //-------------------------------

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer = new CourseCategory { Title = "تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر", };
            CourseCategories.Add(TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer);//24
            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer = CourseCategories[i++];

            DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar = new CourseCategory { Title = "یک درس از دوره کارشناسی دانشکده های دیگر", };
            CourseCategories.Add(DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar);//25
            DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar = CourseCategories[i++];

            DarseEkhtiariAzArshadeComputer = new CourseCategory { Title = "یک درس از کارشناسی ارشد رشته مهندسی کامپیوتر", };
            CourseCategories.Add(DarseEkhtiariAzArshadeComputer);//26
            DarseEkhtiariAzArshadeComputer = CourseCategories[i++];



            BasteMakhsooseNarmafzarBareTakhasosieShabake = new CourseCategory { Title = "بسته مخصوص نرم افزار برای تخصصی شبکه", };
            CourseCategories.Add(BasteMakhsooseNarmafzarBareTakhasosieShabake);//28
            BasteMakhsooseNarmafzarBareTakhasosieShabake = CourseCategories[i++];

            BasteMakhsooseSakhtAfzarBareTakhasosieShabake = new CourseCategory { Title = "بسته مخصوص سخت افزار برای تخصصی شبکه", };
            CourseCategories.Add(BasteMakhsooseSakhtAfzarBareTakhasosieShabake);//29
            BasteMakhsooseSakhtAfzarBareTakhasosieShabake = CourseCategories[i++];

            //-------------------------------

            KhateTire_dorooseOmoomiVaMaaref = new CourseCategory { Title = "-", };
            CourseCategories.Add(KhateTire_dorooseOmoomiVaMaaref);//30
            KhateTire_dorooseOmoomiVaMaaref = CourseCategories[i++];


            KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri = new CourseCategory { Title = "-", };
            CourseCategories.Add(KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);//31
            KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri = CourseCategories[i++];

            KhateTire_darsHayeEkhtiari = new CourseCategory { Title = "-", };
            CourseCategories.Add(KhateTire_darsHayeEkhtiari);//32
            KhateTire_darsHayeEkhtiari = CourseCategories[i++];

            //-------------------------------

            #endregion
            for (int k = 0; k < CourseCategories.Count; k++)
            {
                CourseCategory cc = CourseCategories[k];
                cc.Id = k;
            }
            #endregion

            i = 0;
            #region  Courses

            #region 1
            AndisheEslami1 = new Course
            {
                Title = "انديشه اسلامي يك - مبدا ومعاد",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AndisheEslami1);//0
            AndisheEslami1 = Courses[i++];

            AndisheEslami2 = new Course
            {
                Title = "انديشه اسلامي دو - مبدا ومعاد",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AndisheEslami2);//1
            AndisheEslami2 = Courses[i++];

            EnsanDarEslam = new Course
            {
                Title = "انسان در اسلام",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(EnsanDarEslam);//2
            EnsanDarEslam = Courses[i++];

            HoghoogheEjtemaiVaSiasiDarEslam = new Course
            {
                Title = "حقوق اجتماعی و سیاسی در اسلام",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(HoghoogheEjtemaiVaSiasiDarEslam);//3
            HoghoogheEjtemaiVaSiasiDarEslam = Courses[i++];

            //------------------------------

            FalsafeAkhlagh = new Course
            {
                Title = "فلسفه اخلاق",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(FalsafeAkhlagh);//4
            FalsafeAkhlagh = Courses[i++];

            AkhlagheEslami_mabaniVaMafahim = new Course
            {
                Title = "اخلاق اسلامی",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AkhlagheEslami_mabaniVaMafahim);//5
            AkhlagheEslami_mabaniVaMafahim = Courses[i++];

            AieeneZendegi = new Course
            {
                Title = "آیین زندگی - اخلاق کاربردی",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AieeneZendegi);//6
            AieeneZendegi = Courses[i++];

            ErfaneAmalieEslami = new Course
            {
                Title = "عرفان عملی اسلامی",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(ErfaneAmalieEslami);//7
            ErfaneAmalieEslami = Courses[i++];

            //------------------------------

            EnghelabeEslamieIran = new Course
            {
                Title = "انقلاب اسلامی ایران",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(EnghelabeEslamieIran);//8
            EnghelabeEslamieIran = Courses[i++];

            AshenaieeBaGhanooneAsasieJomhoorieEslamieIran = new Course
            {
                Title = "آشنایی با قانون اساسی جمهوری اسلامی ایران",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AshenaieeBaGhanooneAsasieJomhoorieEslamieIran);//9
            AshenaieeBaGhanooneAsasieJomhoorieEslamieIran = Courses[i++];

            AndisheSiasieAmamKhomeyni = new Course
            {
                Title = "آشنایی با اندیشه سیاسی امام خمینی",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AndisheSiasieAmamKhomeyni);//10
            AndisheSiasieAmamKhomeyni = Courses[i++];

            //------------------------------

            TarikheFarhangVaTamadoneEslami = new Course
            {
                Title = "تاریخ فرهنگ و تمدن اسلامی",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarikheFarhangVaTamadoneEslami);//11
            TarikheFarhangVaTamadoneEslami = Courses[i++];

            TarikheTahlilieSadreEslam = new Course
            {
                Title = "تاریخ تحلیل صدر اسلام",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarikheTahlilieSadreEslam);//12
            TarikheTahlilieSadreEslam = Courses[i++];

            TarikheEmamat = new Course
            {
                Title = "تاریخ امامت",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarikheEmamat);//13
            TarikheEmamat = Courses[i++];

            //------------------------------

            TafsireMozooieGhoran = new Course
            {
                Title = "تفسیر موضوعی قرآن",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TafsireMozooieGhoran);//14
            TafsireMozooieGhoran = Courses[i++];


            TafsireMozooieNahjolBalagheh = new Course
            {
                Title = "تفسیر موضوعی نهج البلاغه",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TafsireMozooieNahjolBalagheh);//15
            TafsireMozooieNahjolBalagheh = Courses[i++];

            ZabaneFarsi = new Course
            {
                Title = "زبان فارسی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(ZabaneFarsi);//16
            ZabaneFarsi = Courses[i++];

            ZabaneEnglish = new Course
            {
                Title = "زبان انگلیسی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(ZabaneEnglish);//17
            ZabaneEnglish = Courses[i++];

            TarbiatBadanieYek = new Course
            {
                Title = "تربیت بدنی یک",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarbiatBadanieYek);//18
            TarbiatBadanieYek = Courses[i++];


            TarbiatBadanieDo = new Course
            {
                Title = "تربیت بدنی دو",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarbiatBadanieDo);//19
            TarbiatBadanieDo = Courses[i++];

            DaneshKhanevadeVaJamiat = new Course
            {
                Title = "دانش خانواده و جمعیت",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(DaneshKhanevadeVaJamiat);//20
            DaneshKhanevadeVaJamiat = Courses[i++];

            #endregion

            #region 2

            RiaziOmoomieYek = new Course
            {
                Title = "ریاضی عمومی یک",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(RiaziOmoomieYek);//21
            RiaziOmoomieYek = Courses[i++];

            RiaziOmoomieDo = new Course
            {
                Title = "ریاضی عمومی دو",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(RiaziOmoomieDo);//22
            RiaziOmoomieDo = Courses[i++];

            FizikeYek = new Course
            {
                Title = "فیزیک یک",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(FizikeYek);//23
            FizikeYek = Courses[i++];

            FizikeDo = new Course
            {
                Title = "فیزیک دو",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(FizikeDo);//24
            FizikeDo = Courses[i++];

            AmaroEhtemaleMohandesi = new Course
            {
                Title = "آمار و احتمال مهندسی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AmaroEhtemaleMohandesi);//25
            AmaroEhtemaleMohandesi = Courses[i++];

            MoadelateDifransiel = new Course
            {
                Title = "معادلات دیفرانسیل",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MoadelateDifransiel);//26
            MoadelateDifransiel = Courses[i++];

            KargaheComputer = new Course
            {
                Title = "کارگاه کامپیوتر",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(KargaheComputer);//27
            KargaheComputer = Courses[i++];

            AzmayeshgaheFizikDo = new Course
            {
                Title = "آزمایشگاه فیزیک دو",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheFizikDo);//28
            AzmayeshgaheFizikDo = Courses[i++];

            #endregion

            #region 3

            MabanieComputerVaBarnameSazi = new Course
            {
                Title = "مبانی کامپیوتر و برنامه سازی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabanieComputerVaBarnameSazi);//29
            MabanieComputerVaBarnameSazi = Courses[i++];

            MadarHayeElectrici = new Course
            {
                Title = "مدار های الکتریکی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MadarHayeElectrici);//30
            MadarHayeElectrici = Courses[i++];

            RiaziateGosasteh = new Course
            {
                Title = "ریاضیات گسسته",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(RiaziateGosasteh);//31
            RiaziateGosasteh = Courses[i++];

            BarnameSaziePishrafteh = new Course
            {
                Title = "برنامه سازی پیشرفته",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(BarnameSaziePishrafteh);//32
            BarnameSaziePishrafteh = Courses[i++];

            SakhtemanHayeDadeh = new Course
            {
                Title = "ساختمان های داده",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(SakhtemanHayeDadeh);//33
            SakhtemanHayeDadeh = Courses[i++];

            MadarHayeManteghi = new Course
            {
                Title = "مدار های منطقی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MadarHayeManteghi);//34
            MadarHayeManteghi = Courses[i++];

            NazarieZabanHaVaMashinHa = new Course
            {
                Title = "نظریه زبان ها و ماشین ها",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(NazarieZabanHaVaMashinHa);//35
            NazarieZabanHaVaMashinHa = Courses[i++];

            ZabaneTakhasosi = new Course
            {
                Title = "زبان تخصصی",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(ZabaneTakhasosi);//36
            ZabaneTakhasosi = Courses[i++];

            RaveshePajoosheshVaEraeh = new Course
            {
                Title = "روش پژوهش و ارايه",
                Units = 2,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(RaveshePajoosheshVaEraeh);//37
            RaveshePajoosheshVaEraeh = Courses[i++];

            RiaziateMohandesi = new Course
            {
                Title = "ریاضیات مهندسی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(RiaziateMohandesi);//38
            RiaziateMohandesi = Courses[i++];


            MemarieComputer = new Course
            {
                Title = "معماری کامپیوتر",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MemarieComputer);//39
            MemarieComputer = Courses[i++];

            SystemHayeAmel = new Course
            {
                Title = "سیستم های عامل",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(SystemHayeAmel);//40
            SystemHayeAmel = Courses[i++];

            TarahieAlgorithmHa = new Course
            {
                Title = "طراحی الگوریتم ها",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarahieAlgorithmHa);//41
            TarahieAlgorithmHa = Courses[i++];

            TarahieCopmuterieSystemHayeDigital = new Course
            {
                Title = "طراحی کامپیوتری سیستم های دیجیتال",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarahieCopmuterieSystemHayeDigital);//42
            TarahieCopmuterieSystemHayeDigital = Courses[i++];

            SignalhaVaSystemHa = new Course
            {
                Title = "سیگنال ها و سیستم ها",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(SignalhaVaSystemHa);//43
            SignalhaVaSystemHa = Courses[i++];

            RizPardazandehVaZabanehAssemblie = new Course
            {
                Title = "ریزپردازنده و زبان اسمبلی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(RizPardazandehVaZabanehAssemblie);//44
            RizPardazandehVaZabanehAssemblie = Courses[i++];

            ShabakeHayeComputeri = new Course
            {
                Title = "شبکه های کامپیوتری",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(ShabakeHayeComputeri);//45
            ShabakeHayeComputeri = Courses[i++];

            HoosheMasnooiVaSystemHayeKhebreh = new Course
            {
                Title = "هوش مصنوعی و سیستم ها خبره",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(HoosheMasnooiVaSystemHayeKhebreh);//46
            HoosheMasnooiVaSystemHayeKhebreh = Courses[i++];

            OsooleTarahieCompiler = new Course
            {
                Title = "اصول طراحی کامپایلر",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(OsooleTarahieCompiler);//47
            OsooleTarahieCompiler = Courses[i++];

            AzmayeshgaheSystemHayeAmel = new Course
            {
                Title = "آزمایشگاه سیستم های عامل",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheSystemHayeAmel);//48
            AzmayeshgaheSystemHayeAmel = Courses[i++];

            AzmayeshgaheMadarHayeManteghiVaMemarieComputer = new Course
            {
                Title = "آزمایشگاه مدارهای منطقی و معماری کامپیوتر",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheMadarHayeManteghiVaMemarieComputer);//49
            AzmayeshgaheMadarHayeManteghiVaMemarieComputer = Courses[i++];

            AzmayeshgaheRizpardazandeh = new Course
            {
                Title = "آزمایشگاه ریزپردازنده",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheRizpardazandeh);//50
            AzmayeshgaheRizpardazandeh = Courses[i++];

            AzmayeshgaheShabakeHayeComputeri = new Course
            {
                Title = "آزمایشگاه شبکه های کامپیوتری",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheShabakeHayeComputeri);//51
            AzmayeshgaheShabakeHayeComputeri = Courses[i++];

            #endregion

            #region 4

            MadarHayeElectronici = new Course
            {
                Title = "مدار های الکترونیکی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MadarHayeElectronici);//52
            MadarHayeElectronici = Courses[i++];

            ElectroniceDigital = new Course
            {
                Title = "الکترونیک دیجیتال",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(ElectroniceDigital);//53
            ElectroniceDigital = Courses[i++];

            EnteghaleDadeha = new Course
            {
                Title = "انتقال داده ها",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(EnteghaleDadeha);//54
            EnteghaleDadeha = Courses[i++];

            SystemHayeControleKhati = new Course
            {
                Title = "سیستم های کنترل خطی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(SystemHayeControleKhati);//55
            SystemHayeControleKhati = Courses[i++];

            AzmayeshgaheMadarhayeElectronici = new Course
            {
                Title = "آزمایشگاه مدارهای الکترونیکی",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheMadarhayeElectronici);//56
            AzmayeshgaheMadarhayeElectronici = Courses[i++];

            AzmayeshgaheElectroniceDigital = new Course
            {
                Title = "آزمایشگاه الکترونیک دیجیتال",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheElectroniceDigital);//57
            AzmayeshgaheElectroniceDigital = Courses[i++];

            AzmayeshgaheAbzarHayeTarrahiBaKomakeComputer = new Course
            {
                Title = "آزمایشگاه ابزارهای طراحی با کمک کامپیوتر",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheAbzarHayeTarrahiBaKomakeComputer);//58
            AzmayeshgaheAbzarHayeTarrahiBaKomakeComputer = Courses[i++];

            KarAmoozieMemari = new Course
            {
                Title = "کارآموزی معماری سیستم ها",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 80,
            };
            Courses.Add(KarAmoozieMemari);//59
            KarAmoozieMemari = Courses[i++];

            ProjecteMemarieComputer = new Course
            {
                Title = "پروژه معماری کامپیوتر",
                Units = 3,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 100,
            };
            Courses.Add(ProjecteMemarieComputer);//60
            ProjecteMemarieComputer = Courses[i++];
            //-------------------------------------

            TahliloTarrahieSystemHa = new Course
            {
                Title = "تحلیل و طراحی سیستم ها",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TahliloTarrahieSystemHa);//61
            TahliloTarrahieSystemHa = Courses[i++];

            PaygaheDadeHa = new Course
            {
                Title = "پایگاه داده ها",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(PaygaheDadeHa);//62
            PaygaheDadeHa = Courses[i++];

            TarrahieZabanHayeBarnameNevisi = new Course
            {
                Title = "طراحی زبان های برنامه نویسی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarrahieZabanHayeBarnameNevisi);//63
            TarrahieZabanHayeBarnameNevisi = Courses[i++];

            MohandesieNarmafzar = new Course
            {
                Title = "مهندسی نرم افزار",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MohandesieNarmafzar);//64
            MohandesieNarmafzar = Courses[i++];

            MohandesieInternet = new Course
            {
                Title = "مهندسی اینترنت",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MohandesieInternet);//65
            MohandesieInternet = Courses[i++];

            KarAmoozieNarmafzar = new Course
            {
                Title = "کارآموزی نرم افزار",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 80,
            };
            Courses.Add(KarAmoozieNarmafzar);//66
            KarAmoozieNarmafzar = Courses[i++];

            ProjectNarmafzar = new Course
            {
                Title = "پروژه نرم افزار",
                Units = 3,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 100,
            };
            Courses.Add(ProjectNarmafzar);//67
            ProjectNarmafzar = Courses[i++];

            //-------------------------------------

            AmniateShabake = new Course
            {
                Title = "امنیت شبکه",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AmniateShabake);//68
            AmniateShabake = Courses[i++];

            MabanieRayanesheAmn = new Course
            {
                Title = "مبانی رایانش امن",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabanieRayanesheAmn);//69
            MabanieRayanesheAmn = Courses[i++];

            AmniateSystemHayePaye = new Course
            {
                Title = "امنیت سیستم های پایه",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AmniateSystemHayePaye);//70
            AmniateSystemHayePaye = Courses[i++];

            ModiriateAmniateEttelaat = new Course
            {
                Title = "مدیریت امنیت اطلاعات",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(ModiriateAmniateEttelaat);//71
            ModiriateAmniateEttelaat = Courses[i++];

            MabanieRamznegari = new Course
            {
                Title = "مبانی رمزنگاری",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabanieRamznegari);//72
            MabanieRamznegari = Courses[i++];

            ToseeAmneNarmafzar = new Course
            {
                Title = "توسعه امن نرم افزار",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(ToseeAmneNarmafzar);//73
            ToseeAmneNarmafzar = Courses[i++];

            HoghooghoAdeleElectroniciDarAmniat = new Course
            {
                Title = "حقوق و ادله الکترونیکی در امنیت",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(HoghooghoAdeleElectroniciDarAmniat);//74
            HoghooghoAdeleElectroniciDarAmniat = Courses[i++];

            KarAmoozieRayanesheAmn = new Course
            {
                Title = "کارآموزی رایانش امن",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 80,
            };
            Courses.Add(KarAmoozieRayanesheAmn);//75
            KarAmoozieRayanesheAmn = Courses[i++];

            ProjectRayanesheAmn = new Course
            {
                Title = "پروژه رایانش امن",
                Units = 3,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 100,
            };
            Courses.Add(ProjectRayanesheAmn);//76
            ProjectRayanesheAmn = Courses[i++];

            //-------------------------------------

            OsooleFanavarieEttelaat = new Course
            {
                Title = "اصول فناوری اطلاعات",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(OsooleFanavarieEttelaat);//77
            OsooleFanavarieEttelaat = Courses[i++];

            OsooleModiratoVaBarnameRizieRahbordieFanavarieEttelaat = new Course
            {
                Title = "اصول مدیریت و برنامه ریزی راهبردی فناوری اطلاعات",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(OsooleModiratoVaBarnameRizieRahbordieFanavarieEttelaat);//78
            OsooleModiratoVaBarnameRizieRahbordieFanavarieEttelaat = Courses[i++];

            ModiriateProjectHayeFanavarieEttelaat = new Course
            {
                Title = "مدیریت پروژه های فناوری اطلاعات",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(ModiriateProjectHayeFanavarieEttelaat);//79
            ModiriateProjectHayeFanavarieEttelaat = Courses[i++];

            YekparcheSazieKarbordHayeSazmani = new Course
            {
                Title = "یکپارچه سازی کاربردهای سازمانی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(YekparcheSazieKarbordHayeSazmani);//80
            YekparcheSazieKarbordHayeSazmani = Courses[i++];

            EghtesadeMohandesi = new Course
            {
                Title = "اقتصاد مهندسی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(EghtesadeMohandesi);//81
            EghtesadeMohandesi = Courses[i++];

            TejarateElectronici = new Course
            {
                Title = "تجارت الکترونیکی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TejarateElectronici);//82
            TejarateElectronici = Courses[i++];

            KarAmoozieFanavarieEttelaat = new Course
            {
                Title = "کارآموزی فناوری اطلاعات",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 80,
            };
            Courses.Add(KarAmoozieFanavarieEttelaat);//83
            KarAmoozieFanavarieEttelaat = Courses[i++];

            ProjecteFanavarieEttelaat = new Course
            {
                Title = "پروژه فناوری اطلاعات",
                Units = 3,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 100,
            };
            Courses.Add(ProjecteFanavarieEttelaat);//84
            ProjecteFanavarieEttelaat = Courses[i++];

            #endregion

            #region 5

            HamTarrahieSakhtafzar_Narmafzar = new Course
            {
                Title = "هم طراحی سخت افزار - نرم افزار",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(HamTarrahieSakhtafzar_Narmafzar);//85
            HamTarrahieSakhtafzar_Narmafzar = Courses[i++];

            SystemHayeNahoftehVaBiderang = new Course
            {
                Title = "سیستم های نهفته و بیدرنگ",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(SystemHayeNahoftehVaBiderang);//86
            SystemHayeNahoftehVaBiderang = Courses[i++];

            TarahieSystemHayeMojtamaePorTarakom = new Course
            {
                Title = "طراحی سیستم های مجتمع پر تراکم",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarahieSystemHayeMojtamaePorTarakom);//87
            TarahieSystemHayeMojtamaePorTarakom = Courses[i++];

            MemarieShetabdahandehHayeSheygera = new Course
            {
                Title = "معماری شتاب دهنده های شی گرا",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MemarieShetabdahandehHayeSheygera);//88
            MemarieShetabdahandehHayeSheygera = Courses[i++];

            TarahieMadarHayeVaset = new Course
            {
                Title = "طراحی مدارهای واسط",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarahieMadarHayeVaset);//89
            TarahieMadarHayeVaset = Courses[i++];

            TarahieMadarHayeDigitaleFerekansBala = new Course
            {
                Title = "طراحی مدارهای دیجیتال فرکانس بالا",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarahieMadarHayeDigitaleFerekansBala);//90
            TarahieMadarHayeDigitaleFerekansBala = Courses[i++];

            //----------------------------------------

            MabanieShabakeHayeBisim = new Course
            {
                Title = "مبانی شبکه های بی سیم",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabanieShabakeHayeBisim);//91
            MabanieShabakeHayeBisim = Courses[i++];

            //----------------------------------------

            MabanieHoosheMohasebati = new Course
            {
                Title = "مبانی هوش محاسباتی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabanieHoosheMohasebati);//92
            MabanieHoosheMohasebati = Courses[i++];

            MabanieBinaieeComputer = new Course
            {
                Title = "مبانی بینایی کامپیوتر",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabanieBinaieeComputer);//93
            MabanieBinaieeComputer = Courses[i++];

            MabaniePardazesheZabanVaGoftar = new Course
            {
                Title = "مبانی پردازش زبان و گفتار",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabaniePardazesheZabanVaGoftar);//94
            MabaniePardazesheZabanVaGoftar = Courses[i++];

            OsooleRobatic = new Course
            {
                Title = "اصول رباتیکز",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(OsooleRobatic);//95
            OsooleRobatic = Courses[i++];

            //-------------------------------

            TaamoleEnsanVaComputer = new Course
            {
                Title = "تعامل انسان و کامپیوتر",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TaamoleEnsanVaComputer);//96
            TaamoleEnsanVaComputer = Courses[i++];

            AzmooneNarmafzar = new Course
            {
                Title = "آزمون نرم افزار",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmooneNarmafzar);//97
            AzmooneNarmafzar = Courses[i++];

            RaveshHayeRasmiDarMohandesiNarmafzar = new Course
            {
                Title = "روش های رسمی در مهندسی نرم افزار",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(RaveshHayeRasmiDarMohandesiNarmafzar);//98
            RaveshHayeRasmiDarMohandesiNarmafzar = Courses[i++];

            TarahieSheygerayeSystemHa = new Course
            {
                Title = "طراحی شی گرا سیستم ها",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarahieSheygerayeSystemHa);//99
            TarahieSheygerayeSystemHa = Courses[i++];

            //-------------------------------

            NazarieVaAlgorithmHayeGraph = new Course
            {
                Title = "نظریه و الگوریتم های گراف",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(NazarieVaAlgorithmHayeGraph);//100
            NazarieVaAlgorithmHayeGraph = Courses[i++];

            NazarieMohasebat = new Course
            {
                Title = "نظریه محاسبات",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(NazarieMohasebat);//101
            NazarieMohasebat = Courses[i++];

            MabaineNazarieBaziHa = new Course
            {
                Title = "مبانی نظریه بازی ها",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabaineNazarieBaziHa);//102
            MabaineNazarieBaziHa = Courses[i++];

            AlgorithmHayePishrafte = new Course
            {
                Title = "الگوریتم های پیشرفته",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AlgorithmHayePishrafte);//103
            AlgorithmHayePishrafte = Courses[i++];

            MoghadameiBarMosabeghateBarnameNevisi = new Course
            {
                Title = "مقدمه ای بر مسابقات برنامه نویسی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MoghadameiBarMosabeghateBarnameNevisi);//104
            MoghadameiBarMosabeghateBarnameNevisi = Courses[i++];

            ManteghDarOloomVaMohandesieComputer = new Course
            {
                Title = "منطق در علوم و مهندسی کامپیوتر",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(ManteghDarOloomVaMohandesieComputer);//105
            ManteghDarOloomVaMohandesieComputer = Courses[i++];

            //-------------------------------

            SystemHayeChandResanie = new Course
            {
                Title = "سیستم های چندرسانه ای",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(SystemHayeChandResanie);//106
            SystemHayeChandResanie = Courses[i++];

            TarahieBaziHayeComputeri = new Course
            {
                Title = "طراحی بازی های کامپیوتری",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(TarahieBaziHayeComputeri);//107
            TarahieBaziHayeComputeri = Courses[i++];

            GraphiceComputeri = new Course
            {
                Title = "گرافیک کامپیوتری",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(GraphiceComputeri);//108
            GraphiceComputeri = Courses[i++];

            MabaniePooyanamaieeComputeri = new Course
            {
                Title = "مبانی پویانمایی کامپیوتری",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabaniePooyanamaieeComputeri);//109
            MabaniePooyanamaieeComputeri = Courses[i++];

            //-------------------------------

            PiadeSazieSystemePaygaheDadeh = new Course
            {
                Title = "پیاده سازی سیستم پایگاه داده",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(PiadeSazieSystemePaygaheDadeh);//110
            PiadeSazieSystemePaygaheDadeh = Courses[i++];

            MabanieDadeKavi = new Course
            {
                Title = "مبانی داده کاوی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabanieDadeKavi);//111
            MabanieDadeKavi = Courses[i++];

            MabanieBazyabieEttelaatVaJostojooyeWeb = new Course
            {
                Title = "مبانی بازیابی اطلاعات و جستجوی وب",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabanieBazyabieEttelaatVaJostojooyeWeb);//112
            MabanieBazyabieEttelaatVaJostojooyeWeb = Courses[i++];

            SystemHayeEttelaateModiriat = new Course
            {
                Title = "سیستم های اطلاعات مدیریت",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(SystemHayeEttelaateModiriat);//113
            SystemHayeEttelaateModiriat = Courses[i++];

            //-------------------------------            

            #endregion

            #region 6

            YekDarsAzKarshenasieArshadeReshteMohandesieComputer1 = new Course
            {
                Title = "یک درس از کارشناسی ارشد رشته مهندسی کامپیوتر1",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(YekDarsAzKarshenasieArshadeReshteMohandesieComputer1);//114
            YekDarsAzKarshenasieArshadeReshteMohandesieComputer1 = Courses[i++];

            MabaheseVijeh1 = new Course
            {
                Title = "مباحث ویژه 1",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabaheseVijeh1);//115
            MabaheseVijeh1 = Courses[i++];

            MabaheseVijeh2 = new Course
            {
                Title = "مباحث ویژه 2",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MabaheseVijeh2);//115
            MabaheseVijeh2 = Courses[i++];

            YekDarsAzDoreKarshenasieReshteHayeDigar1 = new Course
            {
                Title = "1یک درس از دوره کارشناسی رشته های دیگر",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(YekDarsAzDoreKarshenasieReshteHayeDigar1);//117
            YekDarsAzDoreKarshenasieReshteHayeDigar1 = Courses[i++];

            NemooneSazieSystemHayePichideSakhtafzariNarmafzari = new Course
            {
                Title = "نمونه سازی سیستم های پیچیده سخت افزاری - نرم افزاری",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(NemooneSazieSystemHayePichideSakhtafzariNarmafzari);//118
            NemooneSazieSystemHayePichideSakhtafzariNarmafzari = Courses[i++];

            MoghadameiBarElmeAsab = new Course
            {
                Title = "مقدمه ای بر علم اعصاب",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(MoghadameiBarElmeAsab);//119
            MoghadameiBarElmeAsab = Courses[i++];

            AzmayeshgaheMohandesieNarmafzar = new Course
            {
                Title = "آزمایشگاه مهندسی نرم افزار",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheMohandesieNarmafzar);//120
            AzmayeshgaheMohandesieNarmafzar = Courses[i++];

            AzmayeshgaheOsooleTarrahieCompiler = new Course
            {
                Title = "آزمایشگاه اصول طراحی کامپایلر",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheOsooleTarrahieCompiler);//121
            AzmayeshgaheOsooleTarrahieCompiler = Courses[i++];

            AzmayeshgahePaygaheDadeh = new Course
            {
                Title = "آزمایشگاه پایگاه داده",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgahePaygaheDadeh);//122
            AzmayeshgahePaygaheDadeh = Courses[i++];

            AzmayeshgaheMadarHayeElectrici = new Course
            {
                Title = "آزمایشگاه مدار های الکتریکی",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheMadarHayeElectrici);//123
            AzmayeshgaheMadarHayeElectrici = Courses[i++];

            AzmayeshgaheMadarHayeVaset = new Course
            {
                Title = "آزمایشگاه مدار های واسط",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheMadarHayeVaset);//124
            AzmayeshgaheMadarHayeVaset = Courses[i++];

            AzmayeshgaheOsooleRobatic = new Course
            {
                Title = "آزمایشگاه اصول رباتیکز",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheOsooleRobatic);//125
            AzmayeshgaheOsooleRobatic = Courses[i++];

            AzmayeshgaheGraphiceComputeri = new Course
            {
                Title = "آزمایشگاه گرافیک کامپیوتری",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheGraphiceComputeri);//126
            AzmayeshgaheGraphiceComputeri = Courses[i++];

            AzmayeshgaheBaziHayeComputeri = new Course
            {
                Title = "آزمایشگاه بازی های کامپیوتری",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheBaziHayeComputeri);//127
            AzmayeshgaheBaziHayeComputeri = Courses[i++];

            AzmayeshgaheVagheiateMajazi = new Course
            {
                Title = "آزمایشگاه واقعیت مجازی",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheVagheiateMajazi);//128
            AzmayeshgaheVagheiateMajazi = Courses[i++];

            AzmayeshgaheAmniateShabakeh = new Course
            {
                Title = "آزمایشگاه امنیت شبکه",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheAmniateShabakeh);//129
            AzmayeshgaheAmniateShabakeh = Courses[i++];

            KargaheSakhteRobot = new Course
            {
                Title = "کارگاه ساخت ربات",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(KargaheSakhteRobot);//130
            KargaheSakhteRobot = Courses[i++];

            KargaheBarnamehnevisieMatlab = new Course
            {
                Title = "کارگاه برنامه نویسی مت لب",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(KargaheBarnamehnevisieMatlab);//131
            KargaheBarnamehnevisieMatlab = Courses[i++];

            AzmayeshgaheAutomationeSanati = new Course
            {
                Title = "آزمایشگاه اتوماسیون صنعتی",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheAutomationeSanati);//132
            AzmayeshgaheAutomationeSanati = Courses[i++];

            AzmayeshgaheSystemHayeControlKhati = new Course
            {
                Title = "آزمایشگاه سیستم های کنترل خطی",
                Units = 1,
                Status = CourseStatus.PRACTICAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(AzmayeshgaheSystemHayeControlKhati);//133
            AzmayeshgaheSystemHayeControlKhati = Courses[i++];

            SystemHayeAutomationeSanati = new Course
            {
                Title = "سیستم های انوماسیون صنعتی",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(SystemHayeAutomationeSanati);//134
            SystemHayeAutomationeSanati = Courses[i++];


            //oloomoMaarefeDefaeMoghadas = new Course
            //{
            //    Title = "علوم و معارف دفاع مقدس",
            //    Units = 2,
            //    Status = CourseStatus.THERORYCAL,
            //    MinRequireTerm = 1,
            //    MinReuireUnits = 0,
            //};
            //Courses.Add(oloomoMaarefeDefaeMoghadas);//135
            //oloomoMaarefeDefaeMoghadas = Courses[i++];

            YekDarsAzKarshenasieArshadeReshteMohandesieComputer2 = new Course
            {
                Title = "یک درس از کارشناسی ارشد رشته مهندسی کامپیوتر2",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(YekDarsAzKarshenasieArshadeReshteMohandesieComputer2);//136
            YekDarsAzKarshenasieArshadeReshteMohandesieComputer2 = Courses[i++];

            YekDarsAzKarshenasieArshadeReshteMohandesieComputer3 = new Course
            {
                Title = "یک درس از کارشناسی ارشد رشته مهندسی کامپیوتر3",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(YekDarsAzKarshenasieArshadeReshteMohandesieComputer3);//137
            YekDarsAzKarshenasieArshadeReshteMohandesieComputer3 = Courses[i++];

            YekDarsAzDoreKarshenasieReshteHayeDigar2 = new Course
            {
                Title = "یک درس از دوره کارشناسی رشته های دیگر2",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(YekDarsAzDoreKarshenasieReshteHayeDigar2);//138
            YekDarsAzDoreKarshenasieReshteHayeDigar2 = Courses[i++];

            YekDarsAzDoreKarshenasieReshteHayeDigar3 = new Course
            {
                Title = "یک درس از دوره کارشناسی رشته های دیگر3",
                Units = 3,
                Status = CourseStatus.THERORYCAL,
                MinRequireTerm = 1,
                MinReuireUnits = 0,
            };
            Courses.Add(YekDarsAzDoreKarshenasieReshteHayeDigar3);//139
            YekDarsAzDoreKarshenasieReshteHayeDigar3 = Courses[i++];


            #endregion

            for (int k = 0; k < Courses.Count; k++)
            {
                Course c = Courses[k];
                c.Id = k;
                c.CodeInDesUni = Courses[k].CodeInDesUni;
                c.CorrespondingTitleInDesUni = Courses[k].Title;
            }

            #endregion

            i = 0;
            #region Gates

            #region 1
            Gate_root_dorooseOmoomiVaMaaref = new Gate
            {
                SrcCourseCategory = Root,
                DesCourseCategory = DorooseOmoomiVaMaaref,
            };
            Gates.Add(Gate_root_dorooseOmoomiVaMaaref);
            Gate_root_dorooseOmoomiVaMaaref = Gates[i++];

            Gate_root_darsHayePaye = new Gate
            {
                SrcCourseCategory = Root,
                DesCourseCategory = DarsHayePaye,
            };
            Gates.Add(Gate_root_darsHayePaye);
            Gate_root_darsHayePaye = Gates[i++];

            Gate_root_darsHayeAsli = new Gate
            {
                SrcCourseCategory = Root,
                DesCourseCategory = DarsHayeAsli,
            };
            Gates.Add(Gate_root_darsHayeAsli);
            Gate_root_darsHayeAsli = Gates[i++];

            Gate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer = new Gate
            {
                SrcCourseCategory = Root,
                DesCourseCategory = DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer,
            };
            Gates.Add(Gate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer);
            Gate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer = Gates[i++];

            Gate_root_darsHayeTamarkozHayeEkhtiari = new Gate
            {
                SrcCourseCategory = Root,
                DesCourseCategory = DarsHayeTamarkozHayeEkhtiari,
            };
            Gates.Add(Gate_root_darsHayeTamarkozHayeEkhtiari);
            Gate_root_darsHayeTamarkozHayeEkhtiari = Gates[i++];

            Gate_root_darsHayeEkhtiari = new Gate
            {
                SrcCourseCategory = Root,
                DesCourseCategory = DarsHayeEkhtiari,
            };
            Gates.Add(Gate_root_darsHayeEkhtiari);
            Gate_root_darsHayeEkhtiari = Gates[i++];

            //--------------------------

            Gate_dorooseOmoomiVaMaaref_mabanieNazarieEslam = new Gate
            {
                SrcCourseCategory = DorooseOmoomiVaMaaref,
                DesCourseCategory = MabanieNazarieEslam,
            };
            Gates.Add(Gate_dorooseOmoomiVaMaaref_mabanieNazarieEslam);
            Gate_dorooseOmoomiVaMaaref_mabanieNazarieEslam = Gates[i++];

            Gate_dorooseOmoomiVaMaaref_akhlagheEslami = new Gate
            {
                SrcCourseCategory = DorooseOmoomiVaMaaref,
                DesCourseCategory = AkhlagheEslami,
            };
            Gates.Add(Gate_dorooseOmoomiVaMaaref_akhlagheEslami);
            Gate_dorooseOmoomiVaMaaref_akhlagheEslami = Gates[i++];

            Gate_dorooseOmoomiVaMaaref_enghelabeEslami = new Gate
            {
                SrcCourseCategory = DorooseOmoomiVaMaaref,
                DesCourseCategory = EnghelabeEslami,
            };
            Gates.Add(Gate_dorooseOmoomiVaMaaref_enghelabeEslami);
            Gate_dorooseOmoomiVaMaaref_enghelabeEslami = Gates[i++];

            Gate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami = new Gate
            {
                SrcCourseCategory = DorooseOmoomiVaMaaref,
                DesCourseCategory = TarikhOtamadoneEslami,
            };
            Gates.Add(Gate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami);
            Gate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami = Gates[i++];

            Gate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami = new Gate
            {
                SrcCourseCategory = DorooseOmoomiVaMaaref,
                DesCourseCategory = AshnaieBaManabeEslami,
            };
            Gates.Add(Gate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami);
            Gate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami = Gates[i++];

            //--------------------------

            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri = new Gate
            {
                SrcCourseCategory = DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer,
                DesCourseCategory = DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri,
            };
            Gates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri = Gates[i++];

            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar = new Gate
            {
                SrcCourseCategory = DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer,
                DesCourseCategory = DarsHayeTakhasosieGerayesheNarmafzar,
            };
            Gates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar);
            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar = Gates[i++];

            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn = new Gate
            {
                SrcCourseCategory = DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer,
                DesCourseCategory = DarsHayeTakhasosieGerayesheRayanesheAmn,
            };
            Gates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn);
            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn = Gates[i++];

            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat = new Gate
            {
                SrcCourseCategory = DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer,
                DesCourseCategory = DarsHayeTakhasosieGerayesheFanavarieEttelaat,
            };
            Gates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat);
            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat = Gates[i++];

            //--------------------------


            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozHayeEkhtiari,
                DesCourseCategory = DarsHayeTamarkozTakhassosieSystemHayeMojtama,
            };
            Gates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama);
            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama = Gates[i++];

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozHayeEkhtiari,
                DesCourseCategory = DarsHayeTamarkozTakhassosieShabakeHayeComputeri,
            };
            Gates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri);
            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri = Gates[i++];

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozHayeEkhtiari,
                DesCourseCategory = DarsHayeTamarkozTakhassosieHoosheMasnooi,
            };
            Gates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi);
            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi = Gates[i++];

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozHayeEkhtiari,
                DesCourseCategory = DarsHayeTamarkozTakhassosieSystemHayeNarmafzari,
            };
            Gates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari);
            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari = Gates[i++];

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozHayeEkhtiari,
                DesCourseCategory = DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat,
            };
            Gates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat);
            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat = Gates[i++];

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozHayeEkhtiari,
                DesCourseCategory = DarsHayeTamarkozTakhassosieBaziHayeComputeri,
            };
            Gates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri);
            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri = Gates[i++];

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozHayeEkhtiari,
                DesCourseCategory = DarsHayeTamarkozTakhassosieSystemHayeEttelaati,
            };
            Gates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati);
            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati = Gates[i++];

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozHayeEkhtiari,
                DesCourseCategory = DarsHayeTamarkozTakhassosieAmniateRayaneh,
            };
            Gates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh);
            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh = Gates[i++];

            //--------------------------

            Gate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer = new Gate
            {
                SrcCourseCategory = DarsHayeEkhtiari,
                DesCourseCategory = DarseEkhtiariAzArshadeComputer,
            };
            Gates.Add(Gate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer);
            Gate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer = Gates[i++];

            Gate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar = new Gate
            {
                SrcCourseCategory = DarsHayeEkhtiari,
                DesCourseCategory = DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar,
            };
            Gates.Add(Gate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar);
            Gate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar = Gates[i++];

            Gate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer = new Gate
            {
                SrcCourseCategory = DarsHayeEkhtiari,
                DesCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
            };
            Gates.Add(Gate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer);
            Gate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer = Gates[i++];

            //--------------------------


            Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozTakhassosieShabakeHayeComputeri,
                DesCourseCategory = BasteMakhsooseNarmafzarBareTakhasosieShabake,
            };
            Gates.Add(Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake);
            Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake = Gates[i++];

            Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozTakhassosieShabakeHayeComputeri,
                DesCourseCategory = BasteMakhsooseSakhtAfzarBareTakhasosieShabake,
            };
            Gates.Add(Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake);
            Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake = Gates[i++];

            //--------------------------


            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri = Gates[i++];

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTakhasosieGerayesheNarmafzar,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar = Gates[i++];

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTakhasosieGerayesheRayanesheAmn,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn = Gates[i++];

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTakhasosieGerayesheFanavarieEttelaat,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat = Gates[i++];

            //--

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTamarkozTakhassosieSystemHayeMojtama,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama = Gates[i++];

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTamarkozTakhassosieShabakeHayeComputeri,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri = Gates[i++];

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTamarkozTakhassosieHoosheMasnooi,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi = Gates[i++];

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTamarkozTakhassosieSystemHayeNarmafzari,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari = Gates[i++];

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat = Gates[i++];

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTamarkozTakhassosieBaziHayeComputeri,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri = Gates[i++];

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTamarkozTakhassosieSystemHayeEttelaati,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati = Gates[i++];

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh = new Gate
            {
                SrcCourseCategory = TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer,
                DesCourseCategory = DarsHayeTamarkozTakhassosieAmniateRayaneh,
            };
            Gates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh);
            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh = Gates[i++];

            //--------------------------

            Gate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref = new Gate
            {
                SrcCourseCategory = DorooseOmoomiVaMaaref,
                DesCourseCategory = KhateTire_dorooseOmoomiVaMaaref,
            };
            Gates.Add(Gate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref);
            Gate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref = Gates[i++];

            Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri = new Gate
            {
                SrcCourseCategory = DarsHayeTamarkozTakhassosieShabakeHayeComputeri,
                DesCourseCategory = KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri,
            };
            Gates.Add(Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);
            Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri = Gates[i++];

            Gate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari = new Gate
            {
                SrcCourseCategory = DarsHayeEkhtiari,
                DesCourseCategory = KhateTire_darsHayeEkhtiari,
            };
            Gates.Add(Gate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari);
            Gate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari = Gates[i++];

            #endregion
            //--------------------------
            for (int k = 0; k < Gates.Count; k++)
            {
                Gate gate = Gates[k];
                gate.Id = k;
            }

            #endregion

            i = 0;

            #region Rel_CourseCategory_Gates

            #region Output Rel

            Root.OutputGates.Add(Gate_root_dorooseOmoomiVaMaaref);

            Root.OutputGates.Add(Gate_root_darsHayePaye);

            Root.OutputGates.Add(Gate_root_darsHayeAsli);

            Root.OutputGates.Add(Gate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer);

            Root.OutputGates.Add(Gate_root_darsHayeTamarkozHayeEkhtiari);

            Root.OutputGates.Add(Gate_root_darsHayeEkhtiari);

            //---------------------

            DorooseOmoomiVaMaaref.OutputGates.Add(Gate_dorooseOmoomiVaMaaref_mabanieNazarieEslam);

            DorooseOmoomiVaMaaref.OutputGates.Add(Gate_dorooseOmoomiVaMaaref_akhlagheEslami);

            DorooseOmoomiVaMaaref.OutputGates.Add(Gate_dorooseOmoomiVaMaaref_enghelabeEslami);

            DorooseOmoomiVaMaaref.OutputGates.Add(Gate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami);

            DorooseOmoomiVaMaaref.OutputGates.Add(Gate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref);

            DorooseOmoomiVaMaaref.OutputGates.Add(Gate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami);

            //---------------------

            DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer.OutputGates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer.OutputGates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar);

            DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer.OutputGates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer.OutputGates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat);

            //---------------------

            DarsHayeTamarkozHayeEkhtiari.OutputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama);

            DarsHayeTamarkozHayeEkhtiari.OutputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            DarsHayeTamarkozHayeEkhtiari.OutputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi);

            DarsHayeTamarkozHayeEkhtiari.OutputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari);

            DarsHayeTamarkozHayeEkhtiari.OutputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            DarsHayeTamarkozHayeEkhtiari.OutputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri);

            DarsHayeTamarkozHayeEkhtiari.OutputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati);

            DarsHayeTamarkozHayeEkhtiari.OutputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh);

            //---------------------

            DarsHayeEkhtiari.OutputGates.Add(Gate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer);

            DarsHayeEkhtiari.OutputGates.Add(Gate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar);

            DarsHayeEkhtiari.OutputGates.Add(Gate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer);

            DarsHayeEkhtiari.OutputGates.Add(Gate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari);

            //---------------------

            DarsHayeTamarkozTakhassosieShabakeHayeComputeri.OutputGates.Add(Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake);

            DarsHayeTamarkozTakhassosieShabakeHayeComputeri.OutputGates.Add(Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake);

            DarsHayeTamarkozTakhassosieShabakeHayeComputeri.OutputGates.Add(Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            //---------------------

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
               .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .OutputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh);

            //---------------------

            #endregion

            #region Input Rel

            DorooseOmoomiVaMaaref.InputGates.Add(Gate_root_dorooseOmoomiVaMaaref);

            DarsHayePaye.InputGates.Add(Gate_root_darsHayePaye);

            DarsHayeAsli.InputGates.Add(Gate_root_darsHayeAsli);

            DarsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer.InputGates.Add(Gate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer);

            DarsHayeTamarkozHayeEkhtiari.InputGates.Add(Gate_root_darsHayeTamarkozHayeEkhtiari);

            DarsHayeEkhtiari.InputGates.Add(Gate_root_darsHayeEkhtiari);

            //-------------------------

            MabanieNazarieEslam.InputGates.Add(Gate_dorooseOmoomiVaMaaref_mabanieNazarieEslam);

            AkhlagheEslami.InputGates.Add(Gate_dorooseOmoomiVaMaaref_akhlagheEslami);

            EnghelabeEslami.InputGates.Add(Gate_dorooseOmoomiVaMaaref_enghelabeEslami);

            TarikhOtamadoneEslami.InputGates.Add(Gate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami);

            KhateTire_dorooseOmoomiVaMaaref.InputGates.Add(Gate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref);

            AshnaieBaManabeEslami.InputGates.Add(Gate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami);

            //-------------------------

            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.InputGates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            DarsHayeTakhasosieGerayesheNarmafzar.InputGates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar);

            DarsHayeTakhasosieGerayesheRayanesheAmn.InputGates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.InputGates.Add(Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat);

            //-------------------------

            DarsHayeTamarkozTakhassosieSystemHayeMojtama.InputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama);

            DarsHayeTamarkozTakhassosieShabakeHayeComputeri.InputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            DarsHayeTamarkozTakhassosieHoosheMasnooi.InputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi);

            DarsHayeTamarkozTakhassosieSystemHayeNarmafzari.InputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari);

            DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat.InputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            DarsHayeTamarkozTakhassosieBaziHayeComputeri.InputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri);

            DarsHayeTamarkozTakhassosieSystemHayeEttelaati.InputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati);

            DarsHayeTamarkozTakhassosieAmniateRayaneh.InputGates.Add(Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh);

            //-------------------------

            DarseEkhtiariAzArshadeComputer.InputGates.Add(Gate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer);

            DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar.InputGates.Add(Gate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar);

            TaHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer.InputGates.Add(Gate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer);

            KhateTire_darsHayeEkhtiari.InputGates.Add(Gate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari);

            //-------------------------

            BasteMakhsooseNarmafzarBareTakhasosieShabake.InputGates.Add(Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake);

            BasteMakhsooseSakhtAfzarBareTakhasosieShabake.InputGates.Add(Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake);

            KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri.InputGates.Add(Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            //-------------------------



            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            DarsHayeTakhasosieGerayesheNarmafzar.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar);

            DarsHayeTakhasosieGerayesheRayanesheAmn.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat);

            //--

            DarsHayeTamarkozTakhassosieSystemHayeMojtama.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama);

            DarsHayeTamarkozTakhassosieShabakeHayeComputeri.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            DarsHayeTamarkozTakhassosieHoosheMasnooi.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi);

            DarsHayeTamarkozTakhassosieSystemHayeNarmafzari.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari);

            DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            DarsHayeTamarkozTakhassosieBaziHayeComputeri.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri);

            DarsHayeTamarkozTakhassosieSystemHayeEttelaati.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati);

            DarsHayeTamarkozTakhassosieAmniateRayaneh.InputGates.Add(Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh);


            //-------------------------

            #endregion

            #endregion

            i = 0;

            #region Rel_CourseCategory_Courses

            AndisheEslami1.CourseCategories.Add(MabanieNazarieEslam);
            MabanieNazarieEslam.Courses.Add(AndisheEslami1);

            AndisheEslami2.CourseCategories.Add(MabanieNazarieEslam);
            MabanieNazarieEslam.Courses.Add(AndisheEslami2);

            EnsanDarEslam.CourseCategories.Add(MabanieNazarieEslam);
            MabanieNazarieEslam.Courses.Add(EnsanDarEslam);

            HoghoogheEjtemaiVaSiasiDarEslam.CourseCategories.Add(MabanieNazarieEslam);
            MabanieNazarieEslam.Courses.Add(HoghoogheEjtemaiVaSiasiDarEslam);

            //-----------------

            FalsafeAkhlagh.CourseCategories.Add(AkhlagheEslami);
            AkhlagheEslami.Courses.Add(FalsafeAkhlagh);

            AkhlagheEslami_mabaniVaMafahim.CourseCategories.Add(AkhlagheEslami);
            AkhlagheEslami.Courses.Add(AkhlagheEslami_mabaniVaMafahim);

            AieeneZendegi.CourseCategories.Add(AkhlagheEslami);
            AkhlagheEslami.Courses.Add(AieeneZendegi);

            ErfaneAmalieEslami.CourseCategories.Add(AkhlagheEslami);
            AkhlagheEslami.Courses.Add(ErfaneAmalieEslami);

            //-----------------

            EnghelabeEslamieIran.CourseCategories.Add(EnghelabeEslami);
            EnghelabeEslami.Courses.Add(EnghelabeEslamieIran);

            AshenaieeBaGhanooneAsasieJomhoorieEslamieIran.CourseCategories.Add(EnghelabeEslami);
            EnghelabeEslami.Courses.Add(AshenaieeBaGhanooneAsasieJomhoorieEslamieIran);

            AndisheSiasieAmamKhomeyni.CourseCategories.Add(EnghelabeEslami);
            EnghelabeEslami.Courses.Add(AndisheSiasieAmamKhomeyni);

            //----------------

            TarikheFarhangVaTamadoneEslami.CourseCategories.Add(TarikhOtamadoneEslami);
            TarikhOtamadoneEslami.Courses.Add(TarikheFarhangVaTamadoneEslami);

            TarikheTahlilieSadreEslam.CourseCategories.Add(TarikhOtamadoneEslami);
            TarikhOtamadoneEslami.Courses.Add(TarikheTahlilieSadreEslam);

            TarikheEmamat.CourseCategories.Add(TarikhOtamadoneEslami);
            TarikhOtamadoneEslami.Courses.Add(TarikheEmamat);

            //----------------

            AshnaieBaManabeEslami.Courses.Add(TafsireMozooieGhoran);
            TafsireMozooieGhoran.CourseCategories.Add(AshnaieBaManabeEslami);

            AshnaieBaManabeEslami.Courses.Add(TafsireMozooieNahjolBalagheh);
            TafsireMozooieNahjolBalagheh.CourseCategories.Add(AshnaieBaManabeEslami);

            //----------------

            KhateTire_dorooseOmoomiVaMaaref.Courses.Add(ZabaneFarsi);
            ZabaneFarsi.CourseCategories.Add(KhateTire_dorooseOmoomiVaMaaref);

            KhateTire_dorooseOmoomiVaMaaref.Courses.Add(ZabaneEnglish);
            ZabaneEnglish.CourseCategories.Add(KhateTire_dorooseOmoomiVaMaaref);

            KhateTire_dorooseOmoomiVaMaaref.Courses.Add(TarbiatBadanieYek);
            TarbiatBadanieYek.CourseCategories.Add(KhateTire_dorooseOmoomiVaMaaref);

            KhateTire_dorooseOmoomiVaMaaref.Courses.Add(TarbiatBadanieDo);
            TarbiatBadanieDo.CourseCategories.Add(KhateTire_dorooseOmoomiVaMaaref);

            KhateTire_dorooseOmoomiVaMaaref.Courses.Add(DaneshKhanevadeVaJamiat);
            DaneshKhanevadeVaJamiat.CourseCategories.Add(KhateTire_dorooseOmoomiVaMaaref);
            //----------------

            DarsHayePaye.Courses.Add(RiaziOmoomieYek);
            RiaziOmoomieYek.CourseCategories.Add(DarsHayePaye);

            DarsHayePaye.Courses.Add(RiaziOmoomieDo);
            RiaziOmoomieDo.CourseCategories.Add(DarsHayePaye);

            DarsHayePaye.Courses.Add(FizikeYek);
            FizikeYek.CourseCategories.Add(DarsHayePaye);

            DarsHayePaye.Courses.Add(FizikeDo);
            FizikeDo.CourseCategories.Add(DarsHayePaye);

            DarsHayePaye.Courses.Add(AmaroEhtemaleMohandesi);
            AmaroEhtemaleMohandesi.CourseCategories.Add(DarsHayePaye);

            DarsHayePaye.Courses.Add(MoadelateDifransiel);
            MoadelateDifransiel.CourseCategories.Add(DarsHayePaye);

            DarsHayePaye.Courses.Add(KargaheComputer);
            KargaheComputer.CourseCategories.Add(DarsHayePaye);

            DarsHayePaye.Courses.Add(AzmayeshgaheFizikDo);
            AzmayeshgaheFizikDo.CourseCategories.Add(DarsHayePaye);

            //----------------

            DarsHayeAsli.Courses.Add(MabanieComputerVaBarnameSazi);
            MabanieComputerVaBarnameSazi.CourseCategories.Add(DarsHayeAsli);


            DarsHayeAsli.Courses.Add(MadarHayeElectrici);
            MadarHayeElectrici.CourseCategories.Add(DarsHayeAsli);


            DarsHayeAsli.Courses.Add(RiaziateGosasteh);
            RiaziateGosasteh.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(BarnameSaziePishrafteh);
            BarnameSaziePishrafteh.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(SakhtemanHayeDadeh);
            SakhtemanHayeDadeh.CourseCategories.Add(DarsHayeAsli);


            DarsHayeAsli.Courses.Add(MadarHayeManteghi);
            MadarHayeManteghi.CourseCategories.Add(DarsHayeAsli);


            DarsHayeAsli.Courses.Add(NazarieZabanHaVaMashinHa);
            NazarieZabanHaVaMashinHa.CourseCategories.Add(DarsHayeAsli);


            DarsHayeAsli.Courses.Add(ZabaneTakhasosi);
            ZabaneTakhasosi.CourseCategories.Add(DarsHayeAsli);


            DarsHayeAsli.Courses.Add(RaveshePajoosheshVaEraeh);
            RaveshePajoosheshVaEraeh.CourseCategories.Add(DarsHayeAsli);


            DarsHayeAsli.Courses.Add(RiaziateMohandesi);
            RiaziateMohandesi.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(MemarieComputer);
            MemarieComputer.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(SystemHayeAmel);
            SystemHayeAmel.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(TarahieAlgorithmHa);
            TarahieAlgorithmHa.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(TarahieCopmuterieSystemHayeDigital);
            TarahieCopmuterieSystemHayeDigital.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(SignalhaVaSystemHa);
            SignalhaVaSystemHa.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(RizPardazandehVaZabanehAssemblie);
            RizPardazandehVaZabanehAssemblie.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(ShabakeHayeComputeri);
            ShabakeHayeComputeri.CourseCategories.Add(DarsHayeAsli);


            DarsHayeAsli.Courses.Add(HoosheMasnooiVaSystemHayeKhebreh);
            HoosheMasnooiVaSystemHayeKhebreh.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(OsooleTarahieCompiler);
            OsooleTarahieCompiler.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(AzmayeshgaheSystemHayeAmel);
            AzmayeshgaheSystemHayeAmel.CourseCategories.Add(DarsHayeAsli);



            DarsHayeAsli.Courses.Add(AzmayeshgaheMadarHayeManteghiVaMemarieComputer);
            AzmayeshgaheMadarHayeManteghiVaMemarieComputer.CourseCategories.Add(DarsHayeAsli);


            DarsHayeAsli.Courses.Add(AzmayeshgaheRizpardazandeh);
            AzmayeshgaheRizpardazandeh.CourseCategories.Add(DarsHayeAsli);


            DarsHayeAsli.Courses.Add(AzmayeshgaheShabakeHayeComputeri);
            AzmayeshgaheShabakeHayeComputeri.CourseCategories.Add(DarsHayeAsli);

            //----------------

            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Add(MadarHayeElectronici);
            MadarHayeElectronici.CourseCategories.Add(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Add(ElectroniceDigital);
            ElectroniceDigital.CourseCategories.Add(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Add(EnteghaleDadeha);
            EnteghaleDadeha.CourseCategories.Add(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);


            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Add(SystemHayeControleKhati);
            SystemHayeControleKhati.CourseCategories.Add(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);


            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Add(AzmayeshgaheMadarhayeElectronici);
            AzmayeshgaheMadarhayeElectronici.CourseCategories.Add(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);


            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Add(AzmayeshgaheElectroniceDigital);
            AzmayeshgaheElectroniceDigital.CourseCategories.Add(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Add(KarAmoozieMemari);
            KarAmoozieMemari.CourseCategories.Add(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.Courses.Add(ProjecteMemarieComputer);
            ProjecteMemarieComputer.CourseCategories.Add(DarsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            //----------------

            DarsHayeTakhasosieGerayesheNarmafzar.Courses.Add(TahliloTarrahieSystemHa);
            TahliloTarrahieSystemHa.CourseCategories.Add(DarsHayeTakhasosieGerayesheNarmafzar);

            DarsHayeTakhasosieGerayesheNarmafzar.Courses.Add(PaygaheDadeHa);
            PaygaheDadeHa.CourseCategories.Add(DarsHayeTakhasosieGerayesheNarmafzar);

            DarsHayeTakhasosieGerayesheNarmafzar.Courses.Add(TarrahieZabanHayeBarnameNevisi);
            TarrahieZabanHayeBarnameNevisi.CourseCategories.Add(DarsHayeTakhasosieGerayesheNarmafzar);

            DarsHayeTakhasosieGerayesheNarmafzar.Courses.Add(MohandesieNarmafzar);
            MohandesieNarmafzar.CourseCategories.Add(DarsHayeTakhasosieGerayesheNarmafzar);

            DarsHayeTakhasosieGerayesheNarmafzar.Courses.Add(MohandesieInternet);
            MohandesieInternet.CourseCategories.Add(DarsHayeTakhasosieGerayesheNarmafzar);

            DarsHayeTakhasosieGerayesheNarmafzar.Courses.Add(KarAmoozieNarmafzar);
            KarAmoozieNarmafzar.CourseCategories.Add(DarsHayeTakhasosieGerayesheNarmafzar);

            DarsHayeTakhasosieGerayesheNarmafzar.Courses.Add(ProjectNarmafzar);
            ProjectNarmafzar.CourseCategories.Add(DarsHayeTakhasosieGerayesheNarmafzar);

            //----------------


            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(PaygaheDadeHa);
            PaygaheDadeHa.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(TahliloTarrahieSystemHa);
            TahliloTarrahieSystemHa.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(AmniateShabake);
            AmniateShabake.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(MabanieRayanesheAmn);
            MabanieRayanesheAmn.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(AmniateSystemHayePaye);
            AmniateSystemHayePaye.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(ModiriateAmniateEttelaat);
            ModiriateAmniateEttelaat.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(MabanieRamznegari);
            MabanieRamznegari.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(ToseeAmneNarmafzar);
            ToseeAmneNarmafzar.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(HoghooghoAdeleElectroniciDarAmniat);
            HoghooghoAdeleElectroniciDarAmniat.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);


            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(KarAmoozieRayanesheAmn);
            KarAmoozieRayanesheAmn.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);

            DarsHayeTakhasosieGerayesheRayanesheAmn.Courses.Add(ProjectRayanesheAmn);
            ProjectRayanesheAmn.CourseCategories.Add(DarsHayeTakhasosieGerayesheRayanesheAmn);

            //----------------

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(TahliloTarrahieSystemHa);
            TahliloTarrahieSystemHa.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(PaygaheDadeHa);
            PaygaheDadeHa.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(OsooleFanavarieEttelaat);
            OsooleFanavarieEttelaat.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(OsooleModiratoVaBarnameRizieRahbordieFanavarieEttelaat);
            OsooleModiratoVaBarnameRizieRahbordieFanavarieEttelaat.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(ModiriateProjectHayeFanavarieEttelaat);
            ModiriateProjectHayeFanavarieEttelaat.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(YekparcheSazieKarbordHayeSazmani);
            YekparcheSazieKarbordHayeSazmani.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(MabanieRayanesheAmn);
            MabanieRayanesheAmn.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(EghtesadeMohandesi);
            EghtesadeMohandesi.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(TejarateElectronici);
            TejarateElectronici.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(KarAmoozieFanavarieEttelaat);
            KarAmoozieFanavarieEttelaat.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            DarsHayeTakhasosieGerayesheFanavarieEttelaat.Courses.Add(ProjecteFanavarieEttelaat);
            ProjecteFanavarieEttelaat.CourseCategories.Add(DarsHayeTakhasosieGerayesheFanavarieEttelaat);

            //----------------

            DarsHayeTamarkozTakhassosieSystemHayeMojtama.Courses.Add(HamTarrahieSakhtafzar_Narmafzar);
            HamTarrahieSakhtafzar_Narmafzar.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeMojtama);


            DarsHayeTamarkozTakhassosieSystemHayeMojtama.Courses.Add(SystemHayeNahoftehVaBiderang);
            SystemHayeNahoftehVaBiderang.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeMojtama);


            DarsHayeTamarkozTakhassosieSystemHayeMojtama.Courses.Add(TarahieSystemHayeMojtamaePorTarakom);
            TarahieSystemHayeMojtamaePorTarakom.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeMojtama);

            DarsHayeTamarkozTakhassosieSystemHayeMojtama.Courses.Add(MemarieShetabdahandehHayeSheygera);
            MemarieShetabdahandehHayeSheygera.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeMojtama);

            DarsHayeTamarkozTakhassosieSystemHayeMojtama.Courses.Add(TarahieMadarHayeVaset);
            TarahieMadarHayeVaset.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeMojtama);

            DarsHayeTamarkozTakhassosieSystemHayeMojtama.Courses.Add(TarahieMadarHayeDigitaleFerekansBala);
            TarahieMadarHayeDigitaleFerekansBala.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeMojtama);

            //----------------


            KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri.Courses.Add(AmniateShabake);
            AmniateShabake.CourseCategories.Add(KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);


            KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri.Courses.Add(SystemHayeNahoftehVaBiderang);
            SystemHayeNahoftehVaBiderang.CourseCategories.Add(KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri.Courses.Add(MabanieShabakeHayeBisim);
            MabanieShabakeHayeBisim.CourseCategories.Add(KhateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            BasteMakhsooseNarmafzarBareTakhasosieShabake.Courses.Add(EnteghaleDadeha);
            EnteghaleDadeha.CourseCategories.Add(BasteMakhsooseNarmafzarBareTakhasosieShabake);

            BasteMakhsooseSakhtAfzarBareTakhasosieShabake.Courses.Add(MohandesieInternet);
            MohandesieInternet.CourseCategories.Add(BasteMakhsooseSakhtAfzarBareTakhasosieShabake);

            //----------------

            DarsHayeTamarkozTakhassosieHoosheMasnooi.Courses.Add(MabanieHoosheMohasebati);
            MabanieHoosheMohasebati.CourseCategories.Add(DarsHayeTamarkozTakhassosieHoosheMasnooi);

            DarsHayeTamarkozTakhassosieHoosheMasnooi.Courses.Add(MabanieBinaieeComputer);
            MabanieBinaieeComputer.CourseCategories.Add(DarsHayeTamarkozTakhassosieHoosheMasnooi);

            DarsHayeTamarkozTakhassosieHoosheMasnooi.Courses.Add(MabaniePardazesheZabanVaGoftar);
            MabaniePardazesheZabanVaGoftar.CourseCategories.Add(DarsHayeTamarkozTakhassosieHoosheMasnooi);

            DarsHayeTamarkozTakhassosieHoosheMasnooi.Courses.Add(OsooleRobatic);
            OsooleRobatic.CourseCategories.Add(DarsHayeTamarkozTakhassosieHoosheMasnooi);

            //----------------

            DarsHayeTamarkozTakhassosieSystemHayeNarmafzari.Courses.Add(TaamoleEnsanVaComputer);
            TaamoleEnsanVaComputer.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeNarmafzari);

            DarsHayeTamarkozTakhassosieSystemHayeNarmafzari.Courses.Add(AzmooneNarmafzar);
            AzmooneNarmafzar.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeNarmafzari);

            DarsHayeTamarkozTakhassosieSystemHayeNarmafzari.Courses.Add(RaveshHayeRasmiDarMohandesiNarmafzar);
            RaveshHayeRasmiDarMohandesiNarmafzar.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeNarmafzari);

            DarsHayeTamarkozTakhassosieSystemHayeNarmafzari.Courses.Add(TarahieSheygerayeSystemHa);
            TarahieSheygerayeSystemHa.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeNarmafzari);

            //----------------

            DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat.Courses.Add(NazarieVaAlgorithmHayeGraph);
            NazarieVaAlgorithmHayeGraph.CourseCategories.Add(DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat.Courses.Add(NazarieMohasebat);
            NazarieMohasebat.CourseCategories.Add(DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat.Courses.Add(MabaineNazarieBaziHa);
            MabaineNazarieBaziHa.CourseCategories.Add(DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat.Courses.Add(AlgorithmHayePishrafte);
            AlgorithmHayePishrafte.CourseCategories.Add(DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat.Courses.Add(MoghadameiBarMosabeghateBarnameNevisi);
            MoghadameiBarMosabeghateBarnameNevisi.CourseCategories.Add(DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat.Courses.Add(ManteghDarOloomVaMohandesieComputer);
            ManteghDarOloomVaMohandesieComputer.CourseCategories.Add(DarsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            //----------------

            DarsHayeTamarkozTakhassosieBaziHayeComputeri.Courses.Add(SystemHayeChandResanie);
            SystemHayeChandResanie.CourseCategories.Add(DarsHayeTamarkozTakhassosieBaziHayeComputeri);

            DarsHayeTamarkozTakhassosieBaziHayeComputeri.Courses.Add(TarahieBaziHayeComputeri);
            TarahieBaziHayeComputeri.CourseCategories.Add(DarsHayeTamarkozTakhassosieBaziHayeComputeri);

            DarsHayeTamarkozTakhassosieBaziHayeComputeri.Courses.Add(GraphiceComputeri);
            GraphiceComputeri.CourseCategories.Add(DarsHayeTamarkozTakhassosieBaziHayeComputeri);


            DarsHayeTamarkozTakhassosieBaziHayeComputeri.Courses.Add(MabaniePooyanamaieeComputeri);
            MabaniePooyanamaieeComputeri.CourseCategories.Add(DarsHayeTamarkozTakhassosieBaziHayeComputeri);

            //----------------


            DarsHayeTamarkozTakhassosieSystemHayeEttelaati.Courses.Add(PiadeSazieSystemePaygaheDadeh);
            PiadeSazieSystemePaygaheDadeh.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeEttelaati);

            DarsHayeTamarkozTakhassosieSystemHayeEttelaati.Courses.Add(MabanieDadeKavi);
            MabanieDadeKavi.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeEttelaati);

            DarsHayeTamarkozTakhassosieSystemHayeEttelaati.Courses.Add(MabanieBazyabieEttelaatVaJostojooyeWeb);
            MabanieBazyabieEttelaatVaJostojooyeWeb.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeEttelaati);

            DarsHayeTamarkozTakhassosieSystemHayeEttelaati.Courses.Add(SystemHayeEttelaateModiriat);
            SystemHayeEttelaateModiriat.CourseCategories.Add(DarsHayeTamarkozTakhassosieSystemHayeEttelaati);

            //----------------

            DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Add(AmniateShabake);
            AmniateShabake.CourseCategories.Add(DarsHayeTamarkozTakhassosieAmniateRayaneh);

            DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Add(MabanieRayanesheAmn);
            MabanieRayanesheAmn.CourseCategories.Add(DarsHayeTamarkozTakhassosieAmniateRayaneh);

            DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Add(AmniateSystemHayePaye);
            AmniateSystemHayePaye.CourseCategories.Add(DarsHayeTamarkozTakhassosieAmniateRayaneh);

            DarsHayeTamarkozTakhassosieAmniateRayaneh.Courses.Add(ModiriateAmniateEttelaat);
            ModiriateAmniateEttelaat.CourseCategories.Add(DarsHayeTamarkozTakhassosieAmniateRayaneh);

            //----------------

            DarseEkhtiariAzArshadeComputer.Courses.Add(YekDarsAzKarshenasieArshadeReshteMohandesieComputer1);
            YekDarsAzKarshenasieArshadeReshteMohandesieComputer1.CourseCategories.Add(DarseEkhtiariAzArshadeComputer);

            DarseEkhtiariAzArshadeComputer.Courses.Add(YekDarsAzKarshenasieArshadeReshteMohandesieComputer2);
            YekDarsAzKarshenasieArshadeReshteMohandesieComputer2.CourseCategories.Add(DarseEkhtiariAzArshadeComputer);

            DarseEkhtiariAzArshadeComputer.Courses.Add(YekDarsAzKarshenasieArshadeReshteMohandesieComputer3);
            YekDarsAzKarshenasieArshadeReshteMohandesieComputer3.CourseCategories.Add(DarseEkhtiariAzArshadeComputer);

            //--

            DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar.Courses.Add(YekDarsAzDoreKarshenasieReshteHayeDigar1);
            YekDarsAzDoreKarshenasieReshteHayeDigar1.CourseCategories.Add(DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar);

            DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar.Courses.Add(YekDarsAzDoreKarshenasieReshteHayeDigar2);
            YekDarsAzDoreKarshenasieReshteHayeDigar2.CourseCategories.Add(DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar);

            DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar.Courses.Add(YekDarsAzDoreKarshenasieReshteHayeDigar3);
            YekDarsAzDoreKarshenasieReshteHayeDigar3.CourseCategories.Add(DarseEkhtiariAzKarshenasieDaneshkadehHayeDigar);

            //--

            KhateTire_darsHayeEkhtiari.Courses.Add(MabaheseVijeh1);
            MabaheseVijeh1.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(MabaheseVijeh2);
            MabaheseVijeh2.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(NemooneSazieSystemHayePichideSakhtafzariNarmafzari);
            NemooneSazieSystemHayePichideSakhtafzariNarmafzari.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(MoghadameiBarElmeAsab);
            MoghadameiBarElmeAsab.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheMohandesieNarmafzar);
            AzmayeshgaheMohandesieNarmafzar.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheOsooleTarrahieCompiler);
            AzmayeshgaheOsooleTarrahieCompiler.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgahePaygaheDadeh);
            AzmayeshgahePaygaheDadeh.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheMadarHayeElectrici);
            AzmayeshgaheMadarHayeElectrici.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheMadarHayeVaset);
            AzmayeshgaheMadarHayeVaset.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheOsooleRobatic);
            AzmayeshgaheOsooleRobatic.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheGraphiceComputeri);
            AzmayeshgaheGraphiceComputeri.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheBaziHayeComputeri);
            AzmayeshgaheBaziHayeComputeri.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheVagheiateMajazi);
            AzmayeshgaheVagheiateMajazi.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheAmniateShabakeh);
            AzmayeshgaheAmniateShabakeh.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(KargaheSakhteRobot);
            KargaheSakhteRobot.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(KargaheBarnamehnevisieMatlab);
            KargaheBarnamehnevisieMatlab.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheAutomationeSanati);
            AzmayeshgaheAutomationeSanati.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(AzmayeshgaheSystemHayeControlKhati);
            AzmayeshgaheSystemHayeControlKhati.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            KhateTire_darsHayeEkhtiari.Courses.Add(SystemHayeAutomationeSanati);
            SystemHayeAutomationeSanati.CourseCategories.Add(KhateTire_darsHayeEkhtiari);

            //khateTire_darsHayeEkhtiari.Courses.Add(nemooneSazieSystemHayePichideSakhtafzariNarmafzari);
            //nemooneSazieSystemHayePichideSakhtafzariNarmafzari.CourseCategories.Add(khateTire_darsHayeEkhtiari);

            //----------------
            #endregion

            #region Rel_Course_Course

            RiaziOmoomieDo.PrerequisiteCourses.Add(RiaziOmoomieYek);

            FizikeDo.PrerequisiteCourses.Add(RiaziOmoomieYek);

            AmaroEhtemaleMohandesi.PrerequisiteCourses.Add(RiaziOmoomieDo);

            MoadelateDifransiel.PrerequisiteCourses.Add(RiaziOmoomieYek);

            KargaheComputer.PrerequisiteCourses.Add(MabanieComputerVaBarnameSazi);

            AzmayeshgaheFizikDo.PrerequisiteCourses.Add(FizikeDo);

            //----------------

            MadarHayeElectrici.PrerequisiteCourses.Add(MoadelateDifransiel);

            RiaziateGosasteh.RequisiteCourses.Add(RiaziOmoomieYek);
            RiaziateGosasteh.RequisiteCourses.Add(MabanieComputerVaBarnameSazi);

            BarnameSaziePishrafteh.PrerequisiteCourses.Add(MabanieComputerVaBarnameSazi);

            SakhtemanHayeDadeh.PrerequisiteCourses.Add(RiaziateGosasteh);
            SakhtemanHayeDadeh.PrerequisiteCourses.Add(BarnameSaziePishrafteh);

            MadarHayeManteghi.RequisiteCourses.Add(RiaziateGosasteh);

            NazarieZabanHaVaMashinHa.PrerequisiteCourses.Add(SakhtemanHayeDadeh);

            ZabaneTakhasosi.PrerequisiteCourses.Add(ZabaneEnglish);

            RaveshePajoosheshVaEraeh.PrerequisiteCourses.Add(ZabaneTakhasosi);

            RiaziateMohandesi.PrerequisiteCourses.Add(RiaziOmoomieDo);
            RiaziateMohandesi.PrerequisiteCourses.Add(MoadelateDifransiel);

            MemarieComputer.PrerequisiteCourses.Add(MadarHayeManteghi);

            SystemHayeAmel.PrerequisiteCourses.Add(SakhtemanHayeDadeh);
            SystemHayeAmel.PrerequisiteCourses.Add(MemarieComputer);

            TarahieAlgorithmHa.PrerequisiteCourses.Add(SakhtemanHayeDadeh);

            TarahieCopmuterieSystemHayeDigital.PrerequisiteCourses.Add(MemarieComputer);

            SignalhaVaSystemHa.PrerequisiteCourses.Add(RiaziateMohandesi);

            RizPardazandehVaZabanehAssemblie.PrerequisiteCourses.Add(MemarieComputer);

            ShabakeHayeComputeri.PrerequisiteCourses.Add(SystemHayeAmel);

            HoosheMasnooiVaSystemHayeKhebreh.PrerequisiteCourses.Add(SakhtemanHayeDadeh);

            OsooleTarahieCompiler.PrerequisiteCourses.Add(SakhtemanHayeDadeh);

            AzmayeshgaheSystemHayeAmel.RequisiteCourses.Add(SystemHayeAmel);

            AzmayeshgaheMadarHayeManteghiVaMemarieComputer.PrerequisiteCourses.Add(MadarHayeManteghi);
            AzmayeshgaheMadarHayeManteghiVaMemarieComputer.RequisiteCourses.Add(MemarieComputer);

            AzmayeshgaheRizpardazandeh.PrerequisiteCourses.Add(RizPardazandehVaZabanehAssemblie);

            AzmayeshgaheShabakeHayeComputeri.RequisiteCourses.Add(ShabakeHayeComputeri);

            //-------------------


            MadarHayeElectronici.PrerequisiteCourses.Add(MadarHayeElectrici);

            ElectroniceDigital.PrerequisiteCourses.Add(MadarHayeElectronici);

            EnteghaleDadeha.PrerequisiteCourses.Add(AmaroEhtemaleMohandesi);
            EnteghaleDadeha.PrerequisiteCourses.Add(SignalhaVaSystemHa);

            SystemHayeControleKhati.PrerequisiteCourses.Add(SignalhaVaSystemHa);

            AzmayeshgaheMadarhayeElectronici.RequisiteCourses.Add(MadarHayeElectronici);

            AzmayeshgaheElectroniceDigital.PrerequisiteCourses.Add(ElectroniceDigital);

            AzmayeshgaheAbzarHayeTarrahiBaKomakeComputer.RequisiteCourses.Add(ElectroniceDigital);
            AzmayeshgaheAbzarHayeTarrahiBaKomakeComputer.PrerequisiteCourses.Add(TarahieCopmuterieSystemHayeDigital);

            //-------------------

            TahliloTarrahieSystemHa.PrerequisiteCourses.Add(BarnameSaziePishrafteh);

            PaygaheDadeHa.PrerequisiteCourses.Add(SakhtemanHayeDadeh);

            TarrahieZabanHayeBarnameNevisi.PrerequisiteCourses.Add(OsooleTarahieCompiler);

            MohandesieNarmafzar.PrerequisiteCourses.Add(TahliloTarrahieSystemHa);

            MohandesieInternet.RequisiteCourses.Add(PaygaheDadeHa);
            MohandesieInternet.PrerequisiteCourses.Add(ShabakeHayeComputeri);

            //-------------------

            AmniateShabake.PrerequisiteCourses.Add(ShabakeHayeComputeri);

            MabanieRayanesheAmn.RequisiteCourses.Add(ShabakeHayeComputeri);
            MabanieRayanesheAmn.PrerequisiteCourses.Add(SystemHayeAmel);



            AmniateSystemHayePaye.PrerequisiteCourses.Add(PaygaheDadeHa);
            AmniateSystemHayePaye.PrerequisiteCourses.Add(SystemHayeAmel);

            ModiriateAmniateEttelaat.PrerequisiteCourses.Add(MabanieRayanesheAmn);

            MabanieRamznegari.PrerequisiteCourses.Add(MabanieRayanesheAmn);

            ToseeAmneNarmafzar.PrerequisiteCourses.Add(TahliloTarrahieSystemHa);

            HoghooghoAdeleElectroniciDarAmniat.PrerequisiteCourses.Add(AmniateShabake);
            HoghooghoAdeleElectroniciDarAmniat.PrerequisiteCourses.Add(AmniateSystemHayePaye);

            //-------------------

            YekparcheSazieKarbordHayeSazmani.PrerequisiteCourses.Add(ShabakeHayeComputeri);
            YekparcheSazieKarbordHayeSazmani.PrerequisiteCourses.Add(TahliloTarrahieSystemHa);


            TejarateElectronici.PrerequisiteCourses.Add(EghtesadeMohandesi);
            TejarateElectronici.PrerequisiteCourses.Add(ShabakeHayeComputeri);



            //-------------------

            HamTarrahieSakhtafzar_Narmafzar.PrerequisiteCourses.Add(MemarieComputer);

            SystemHayeNahoftehVaBiderang.PrerequisiteCourses.Add(SystemHayeAmel);
            SystemHayeNahoftehVaBiderang.PrerequisiteCourses.Add(RizPardazandehVaZabanehAssemblie);

            TarahieSystemHayeMojtamaePorTarakom.PrerequisiteCourses.Add(ElectroniceDigital);

            MemarieShetabdahandehHayeSheygera.PrerequisiteCourses.Add(BarnameSaziePishrafteh);
            MemarieShetabdahandehHayeSheygera.PrerequisiteCourses.Add(MemarieComputer);

            TarahieMadarHayeVaset.PrerequisiteCourses.Add(RizPardazandehVaZabanehAssemblie);

            TarahieMadarHayeDigitaleFerekansBala.PrerequisiteCourses.Add(MadarHayeElectrici);

            //-------------------

            MabanieShabakeHayeBisim.PrerequisiteCourses.Add(EnteghaleDadeha);

            //-------------------

            MabanieHoosheMohasebati.PrerequisiteCourses.Add(BarnameSaziePishrafteh);

            MabanieBinaieeComputer.PrerequisiteCourses.Add(MabanieHoosheMohasebati);

            MabaniePardazesheZabanVaGoftar.PrerequisiteCourses.Add(AmaroEhtemaleMohandesi);
            MabaniePardazesheZabanVaGoftar.PrerequisiteCourses.Add(SignalhaVaSystemHa);

            OsooleRobatic.PrerequisiteCourses.Add(SignalhaVaSystemHa);

            //-------------------
            TaamoleEnsanVaComputer.PrerequisiteCourses.Add(TahliloTarrahieSystemHa);

            AzmooneNarmafzar.PrerequisiteCourses.Add(TahliloTarrahieSystemHa);

            RaveshHayeRasmiDarMohandesiNarmafzar.PrerequisiteCourses.Add(TahliloTarrahieSystemHa);

            TarahieSheygerayeSystemHa.PrerequisiteCourses.Add(BarnameSaziePishrafteh);

            //-------------------

            NazarieVaAlgorithmHayeGraph.PrerequisiteCourses.Add(RiaziateGosasteh);

            NazarieMohasebat.PrerequisiteCourses.Add(NazarieZabanHaVaMashinHa);

            MabaineNazarieBaziHa.PrerequisiteCourses.Add(TarahieAlgorithmHa);

            AlgorithmHayePishrafte.PrerequisiteCourses.Add(TarahieAlgorithmHa);

            MoghadameiBarMosabeghateBarnameNevisi.PrerequisiteCourses.Add(TarahieAlgorithmHa);

            ManteghDarOloomVaMohandesieComputer.PrerequisiteCourses.Add(MabanieComputerVaBarnameSazi);
            ManteghDarOloomVaMohandesieComputer.PrerequisiteCourses.Add(RiaziateGosasteh);

            //-------------------

            SystemHayeChandResanie.PrerequisiteCourses.Add(AmaroEhtemaleMohandesi);
            SystemHayeChandResanie.PrerequisiteCourses.Add(SignalhaVaSystemHa);

            TarahieBaziHayeComputeri.PrerequisiteCourses.Add(BarnameSaziePishrafteh);

            GraphiceComputeri.PrerequisiteCourses.Add(BarnameSaziePishrafteh);

            MabaniePooyanamaieeComputeri.PrerequisiteCourses.Add(GraphiceComputeri);

            //-------------------

            PiadeSazieSystemePaygaheDadeh.PrerequisiteCourses.Add(PaygaheDadeHa);

            MabanieDadeKavi.PrerequisiteCourses.Add(PaygaheDadeHa);
            MabanieDadeKavi.PrerequisiteCourses.Add(SakhtemanHayeDadeh);


            MabanieBazyabieEttelaatVaJostojooyeWeb.PrerequisiteCourses.Add(TarahieAlgorithmHa);

            SystemHayeEttelaateModiriat.PrerequisiteCourses.Add(TahliloTarrahieSystemHa);

            //-------------------

            NemooneSazieSystemHayePichideSakhtafzariNarmafzari.PrerequisiteCourses.Add(SystemHayeAmel);
            NemooneSazieSystemHayePichideSakhtafzariNarmafzari.PrerequisiteCourses.Add(MemarieComputer);


            AzmayeshgaheMohandesieNarmafzar.RequisiteCourses.Add(TahliloTarrahieSystemHa);

            AzmayeshgaheOsooleTarrahieCompiler.RequisiteCourses.Add(OsooleTarahieCompiler);

            AzmayeshgahePaygaheDadeh.RequisiteCourses.Add(PaygaheDadeHa);

            AzmayeshgaheMadarHayeElectrici.RequisiteCourses.Add(MadarHayeElectrici);

            AzmayeshgaheMadarHayeVaset.PrerequisiteCourses.Add(TarahieMadarHayeVaset);

            AzmayeshgaheOsooleRobatic.RequisiteCourses.Add(OsooleRobatic);

            AzmayeshgaheGraphiceComputeri.RequisiteCourses.Add(GraphiceComputeri);

            AzmayeshgaheBaziHayeComputeri.RequisiteCourses.Add(TarahieBaziHayeComputeri);

            AzmayeshgaheAmniateShabakeh.RequisiteCourses.Add(AmniateShabake);


            KargaheBarnamehnevisieMatlab.RequisiteCourses.Add(SignalhaVaSystemHa);

            AzmayeshgaheAutomationeSanati.PrerequisiteCourses.Add(SystemHayeControleKhati);

            AzmayeshgaheSystemHayeControlKhati.PrerequisiteCourses.Add(SystemHayeControleKhati);

            SystemHayeAutomationeSanati.PrerequisiteCourses.Add(RizPardazandehVaZabanehAssemblie);

            //-------------------
            #endregion

            i = 0;

            #region Credit

            #region 1
            //-----------------------

            //یعنی برای همه افراد داراری کارت اعتباری مجاز است
            /*
             برای بخش های زیر از این کارت اعتباری استافده می شود
             ریشه به دروس عمومی و معارف اسلامی
             ریشه به درس های پایه
             ریشه به درس های اصلی
             ریشه به درس های تخصصی گرایش های چهارگانه رشته مهندسی کامپیوتر
             ریشه به درس های اختیاری

             دروس عمومی و معارف اسلامی به مبانی نظری اسلام
             دروس عمومی و معارف اسلامی به اخلاق اسلامی
             دروس عمومی و معارف اسلامی به انقلاب اسلامی
             دروس عمومی و معارف اسلامی به تاریخ و تمدن اسلامی
             دروس عمومی و معارف اسلامی به خط تیره دروس عمومی و معارف اسلامی

             درس های اختیاری به یک درس از کارشناسی ارشد مهندسی کامپیوتر
             درس های اختیاری به یک درس از دوره کارشناسی رشته های دیگر
             درس های اختیاری به تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر
             درس های اختیاری به خظ تیره درس های اختیاری

            درس های تمرکز تخصصی شبکه های کامپیوتری به خط تیره شبکه های کامپیوتری

             */

            Credit1 = new CreditCard92
            {
                CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL,
                SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL,
            };

            CreditCards.Add(Credit1);

            /*
             قابل استقاده برای
             ریشه به درس های تخصصی گرایش های چهارگانه رشته مهندسی کامپیوتر
             */
            Credit2 = new CreditCard92
            {
                CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST
            };
            Credit2.CurriculumList.Add(credit_gerayesh_mohandesi_computer);
            Credit2.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit2);

            /*
             قابل استقاده برای
             ریشه به درس های تمرکز اختیاری
             */
            Credit3 = new CreditCard92
            {
                CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST
            };
            Credit3.CurriculumList.Add(credit_gerayeshe_rayaneshe_amn);
            Credit3.CurriculumList.Add(credit_gerayeshe_fanavarie_ettelaat);
            Credit3.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit3.SpecializedFocus.Add(credit_tamrkoze_NA_MOSHAKAS);

            CreditCards.Add(Credit3);

            //-----------------------

            /*
             قابل استقاده برای
             درس های تخصصی گرایش های چهارگانه رشته مهندسی کامپیوتر به درس های تخصصی گرایش معماری سیستم ها
             */

            Credit4 = new CreditCard92
            {
                CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST
            };
            Credit4.CurriculumList.Add(credit_gerayeshe_memarie_system_haye_computeri);
            Credit4.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit4);

            /*
             قابل استقاده برای
             درس های تخصصی گرایش های چهارگانه رشته مهندسی کامپیوتر به درس های تخصصی گرایش نرم افزار
             */

            Credit5 = new CreditCard92
            {
                CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST
            };
            Credit5.CurriculumList.Add(credit_gerayeshe_narmafzar);
            Credit5.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit5);

            /*
             قابل استقاده برای
             درس های تخصصی گرایش های چهارگانه رشته مهندسی کامپیوتر به درس های تخصصی گرایش رایانش امن
             */

            Credit6 = new CreditCard92
            {
                CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST
            };
            Credit6.CurriculumList.Add(credit_gerayeshe_rayaneshe_amn);
            Credit6.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit6);

            /*
             قابل استقاده برای
             درس های تخصصی گرایش های چهارگانه رشته مهندسی کامپیوتر به درس های تخصصی گرایش فناوری اطلاعات
             */

            Credit7 = new CreditCard92
            {
                CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST
            };
            Credit7.CurriculumList.Add(credit_gerayeshe_fanavarie_ettelaat);
            Credit7.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit7);

            //-----------------------

            /*
             قابل استقاده برای
             درس های تمرکز اختیاری به درس های تمرکز اختیاری سیستم های مجتمع
             */

            Credit8 = new CreditCard92
            {
                CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL,
                SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST
            };
            Credit8.SpecializedFocus.Add(credit_tamrkoze_system_haye_mojtama);

            CreditCards.Add(Credit8);

            /*
             قابل استقاده برای
             درس های تمرکز اختیاری به درس های تمرکز اختیاری شبکه های کامپیوتری
             */

            Credit9 = new CreditCard92();
            Credit9.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit9.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST;
            Credit9.SpecializedFocus.Add(credit_tamrkoze_shabake_haye_computer);

            CreditCards.Add(Credit9);

            /*
             قابل استقاده برای
             درس های تمرکز اختیاری به درس های تمرکز اختیاری هوش مصنوعی
             */

            Credit10 = new CreditCard92();
            Credit10.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit10.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST;
            Credit10.SpecializedFocus.Add(credit_tamrkoze_hooshe_masnooie);

            CreditCards.Add(Credit10);

            /*
             قابل استقاده برای
             درس های تمرکز اختیاری به درس های تمرکز اختیاری سیستم های نرم افزاری
             */

            Credit11 = new CreditCard92();
            Credit11.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit11.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST;
            Credit11.SpecializedFocus.Add(credit_tamrkoze_system_haye_narmafzari);

            CreditCards.Add(Credit11);

            /*
             قابل استقاده برای
             درس های تمرکز اختیاری به درس های تمرکز اختیاری الگوریتم و محاسبات
             */

            Credit12 = new CreditCard92();
            Credit12.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit12.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST;
            Credit12.SpecializedFocus.Add(credit_tamrkoze_algorithm_va_mohasebat);

            CreditCards.Add(Credit12);

            /*
             قابل استقاده برای
             درس های تمرکز اختیاری به درس های تمرکز اختیاری بازی های کامپیوتری
             */
            Credit13 = new CreditCard92();
            Credit13.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit13.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST;
            Credit13.SpecializedFocus.Add(credit_tamrkoze_bazi_haye_computeri);

            CreditCards.Add(Credit13);

            /*
             قابل استقاده برای
             درس های تمرکز اختیاری به درس های تمرکز اختیاری سیستم های اطلاعاتی
             */

            Credit14 = new CreditCard92();
            Credit14.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit14.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST;
            Credit14.SpecializedFocus.Add(credit_tamrkoze_system_haye_ettelaati);

            CreditCards.Add(Credit14);

            /*
             قابل استقاده برای
             درس های تمرکز اختیاری به درس های تمرکز اختیاری امنیت رایانه
             */

            Credit15 = new CreditCard92();
            Credit15.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit15.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_IN_LIST;
            Credit15.SpecializedFocus.Add(credit_tamrkoze_amniate_rayaneh);

            CreditCards.Add(Credit15);

            //-----------------------

            /*
            قابل استقاده برای
            تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز تخصصی گرایش معماری سیستم ها
            */

            Credit16 = new CreditCard92();
            Credit16.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit16.CurriculumList.Add(credit_gerayesh_mohandesi_computer);
            Credit16.CurriculumList.Add(credit_gerayeshe_memarie_system_haye_computeri);
            Credit16.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit16);

            /*
            قابل استقاده برای
            تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز تخصصی گرایش نرم افزار
            */

            Credit17 = new CreditCard92();
            Credit17.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit17.CurriculumList.Add(credit_gerayesh_mohandesi_computer);
            Credit17.CurriculumList.Add(credit_gerayeshe_narmafzar);
            Credit17.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit17);

            /*
            قابل استقاده برای
            تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز تخصصی گرایش رایانش امن
            */

            Credit18 = new CreditCard92();
            Credit18.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit18.CurriculumList.Add(credit_gerayesh_mohandesi_computer);
            Credit18.CurriculumList.Add(credit_gerayeshe_rayaneshe_amn);
            Credit18.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit18);

            /*
            قابل استقاده برای
            تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز تخصصی گرایش فناوری اطلاعات
            */

            Credit19 = new CreditCard92();
            Credit19.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit19.CurriculumList.Add(credit_gerayesh_mohandesi_computer);
            Credit19.CurriculumList.Add(credit_gerayeshe_fanavarie_ettelaat);
            Credit19.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit19);

            //-----------------------

            /*
          قابل استقاده برای
          تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز اختیاری سیستم های مجتمع
          */

            Credit20 = new CreditCard92();
            Credit20.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit20.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit20.SpecializedFocus.Add(credit_tamrkoze_NA_MOSHAKAS);
            Credit20.SpecializedFocus.Add(credit_tamrkoze_system_haye_mojtama);

            CreditCards.Add(Credit20);

            /*
           قابل استقاده برای
           تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز اختیاری شبکه های کامپیوتری
           */

            Credit21 = new CreditCard92();
            Credit21.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit21.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit21.SpecializedFocus.Add(credit_tamrkoze_NA_MOSHAKAS);
            Credit21.SpecializedFocus.Add(credit_tamrkoze_shabake_haye_computer);

            CreditCards.Add(Credit21);

            /*
         قابل استقاده برای
         تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز اختیاری هوش مصنوعی
         */

            Credit22 = new CreditCard92();
            Credit22.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit22.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit22.SpecializedFocus.Add(credit_tamrkoze_NA_MOSHAKAS);
            Credit22.SpecializedFocus.Add(credit_tamrkoze_hooshe_masnooie);

            CreditCards.Add(Credit22);

            /*
         قابل استقاده برای
         تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز اختیاری سیستم های نرم افزاری
         */

            Credit23 = new CreditCard92();
            Credit23.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit23.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit23.SpecializedFocus.Add(credit_tamrkoze_NA_MOSHAKAS);
            Credit23.SpecializedFocus.Add(credit_tamrkoze_system_haye_narmafzari);

            CreditCards.Add(Credit23);

            /*
         قابل استقاده برای
         تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز اختیاری الگوریتم و محاسبات
         */

            Credit24 = new CreditCard92();
            Credit24.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit24.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit24.SpecializedFocus.Add(credit_tamrkoze_NA_MOSHAKAS);
            Credit24.SpecializedFocus.Add(credit_tamrkoze_algorithm_va_mohasebat);

            CreditCards.Add(Credit24);

            /*
         قابل استقاده برای
         تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز اختیاری بازی های کامپیوتری
         */

            Credit25 = new CreditCard92();
            Credit25.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit25.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit25.SpecializedFocus.Add(credit_tamrkoze_NA_MOSHAKAS);
            Credit25.SpecializedFocus.Add(credit_tamrkoze_bazi_haye_computeri);

            CreditCards.Add(Credit25);

            /*
         قابل استقاده برای
         تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز اختیاری سیستم های اطلاعاتی
         */

            Credit26 = new CreditCard92();
            Credit26.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit26.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit26.SpecializedFocus.Add(credit_tamrkoze_NA_MOSHAKAS);
            Credit26.SpecializedFocus.Add(credit_tamrkoze_system_haye_ettelaati);

            CreditCards.Add(Credit26);

            /*
         قابل استقاده برای
         تا هشت واحد از درس های گرایش ها یا تمرکز های دیگر مهندسی کامپیوتر به درس های تمرکز اختیاری امنیت رایانه
         */

            Credit27 = new CreditCard92();
            Credit27.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL;
            Credit27.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit27.SpecializedFocus.Add(credit_tamrkoze_NA_MOSHAKAS);
            Credit27.SpecializedFocus.Add(credit_tamrkoze_amniate_rayaneh);

            CreditCards.Add(Credit27);

            //-----------------------

            /*
        قابل استقاده برای
         درس های تمرکز تخصصی شبکه های کامپیوتری به بسته مخصوص نرم افزار برای شبکه
        */
            Credit28 = new CreditCard92();
            Credit28.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit28.CurriculumList.Add(credit_gerayesh_mohandesi_computer);
            Credit28.CurriculumList.Add(credit_gerayeshe_memarie_system_haye_computeri);
            Credit28.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit28);

            /*
       قابل استقاده برای
        درس های تمرکز تخصصی شبکه های کامپیوتری به بسته مخصوص سخت فزار برای شبکه
       */

            Credit29 = new CreditCard92();
            Credit29.CurriculumListType = CreditCardStatus.ALLOWED_TO_ALL_EXCEPT_IN_LIST;
            Credit29.CurriculumList.Add(credit_gerayesh_mohandesi_computer);
            Credit29.CurriculumList.Add(credit_gerayeshe_narmafzar);
            Credit29.SpecializedFocusType = CreditCardStatus.ALLOWED_TO_ALL;

            CreditCards.Add(Credit29);
            #endregion
            //--------------------------
            for (int k = 0; k < CreditCards.Count; k++)
            {
                ICreditCard cc = CreditCards[k];
                cc.Id = k;
            }
            #endregion

            i = 0;
            #region Certificate

            #region level1
            Certificate certificate_root_dorooseOmoomiVaMaaref = new Certificate();
            certificate_root_dorooseOmoomiVaMaaref.CreditList.Add(Credit1);

            Certificates.Add(certificate_root_dorooseOmoomiVaMaaref);
            certificate_root_dorooseOmoomiVaMaaref = Certificates[i++];
            //-


            Certificate certificate_root_darsHayePaye = new Certificate();
            certificate_root_darsHayePaye.CreditList.Add(Credit1);

            Certificates.Add(certificate_root_darsHayePaye);
            certificate_root_darsHayePaye = Certificates[i++];
            //-

            Certificate certificate_root_darsHayeAsli = new Certificate();
            certificate_root_darsHayeAsli.CreditList.Add(Credit1);

            Certificates.Add(certificate_root_darsHayeAsli);
            certificate_root_darsHayeAsli = Certificates[i++];
            //-

            Certificate certificate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer = new Certificate();
            certificate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer.CreditList.Add(Credit2);

            Certificates.Add(certificate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer);
            certificate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer = Certificates[i++];
            //-


            Certificate certificate_root_darsHayeTamarkozHayeEkhtiari = new Certificate();
            certificate_root_darsHayeTamarkozHayeEkhtiari.CreditList.Add(Credit3);

            Certificates.Add(certificate_root_darsHayeTamarkozHayeEkhtiari);
            certificate_root_darsHayeTamarkozHayeEkhtiari = Certificates[i++];
            //-


            Certificate certificate_root_darsHayeEkhtiari = new Certificate();
            certificate_root_darsHayeEkhtiari.CreditList.Add(Credit1);

            Certificates.Add(certificate_root_darsHayeEkhtiari);
            certificate_root_darsHayeEkhtiari = Certificates[i++];
            //-

            //--------------------------

            #endregion

            #region level2


            Certificate certificate_dorooseOmoomiVaMaaref_mabanieNazarieEslam = new Certificate();
            certificate_dorooseOmoomiVaMaaref_mabanieNazarieEslam.CreditList.Add(Credit1);

            Certificates.Add(certificate_dorooseOmoomiVaMaaref_mabanieNazarieEslam);
            certificate_dorooseOmoomiVaMaaref_mabanieNazarieEslam = Certificates[i++];
            //-

            Certificate certificate_dorooseOmoomiVaMaaref_akhlagheEslami = new Certificate();
            certificate_dorooseOmoomiVaMaaref_akhlagheEslami.CreditList.Add(Credit1);

            Certificates.Add(certificate_dorooseOmoomiVaMaaref_akhlagheEslami);
            certificate_dorooseOmoomiVaMaaref_akhlagheEslami = Certificates[i++];
            //-

            Certificate certificate_dorooseOmoomiVaMaaref_enghelabeEslami = new Certificate();
            certificate_dorooseOmoomiVaMaaref_enghelabeEslami.CreditList.Add(Credit1);

            Certificates.Add(certificate_dorooseOmoomiVaMaaref_enghelabeEslami);
            certificate_dorooseOmoomiVaMaaref_enghelabeEslami = Certificates[i++];
            //-


            Certificate certificate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami = new Certificate();
            certificate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami.CreditList.Add(Credit1);

            Certificates.Add(certificate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami);
            certificate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami = Certificates[i++];
            //-


            Certificate certificate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref = new Certificate();
            certificate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref.CreditList.Add(Credit1);

            Certificates.Add(certificate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref);
            certificate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref = Certificates[i++];
            //-

            Certificate certificate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami = new Certificate();
            certificate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami.CreditList.Add(Credit1);

            Certificates.Add(certificate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami);
            certificate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami = Certificates[i++];
            //-
            //----------------------


            Certificate certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri = new Certificate();
            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.CreditList.Add(Credit4);

            Certificates.Add(certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri = Certificates[i++];
            //-


            Certificate certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar = new Certificate();
            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar.CreditList.Add(Credit5);

            Certificates.Add(certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar);
            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar = Certificates[i++];
            //-



            Certificate certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn = new Certificate();
            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn.CreditList.Add(Credit6);

            Certificates.Add(certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn);
            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn = Certificates[i++];
            //-


            Certificate certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat = new Certificate();
            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat.CreditList.Add(Credit7);

            Certificates.Add(certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat);
            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat = Certificates[i++];
            //-

            //----------------------



            Certificate certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama = new Certificate();
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama.CreditList.Add(Credit8);

            Certificates.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama);
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama = Certificates[i++];
            //-



            Certificate certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri = new Certificate();
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri.CreditList.Add(Credit9);

            Certificates.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri);
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri = Certificates[i++];
            //-


            Certificate certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi = new Certificate();
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi.CreditList.Add(Credit10);

            Certificates.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi);
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi = Certificates[i++];
            //-


            Certificate certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari = new Certificate();
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari.CreditList.Add(Credit11);

            Certificates.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari);
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari = Certificates[i++];
            //-

            Certificate certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat = new Certificate();
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat.CreditList.Add(Credit12);

            Certificates.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat);
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat = Certificates[i++];
            //-


            Certificate certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri = new Certificate();
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri.CreditList.Add(Credit13);

            Certificates.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri);
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri = Certificates[i++];
            //-

            Certificate certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati = new Certificate();
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati.CreditList.Add(Credit14);

            Certificates.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati);
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati = Certificates[i++];
            //-

            Certificate certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh = new Certificate();
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh.CreditList.Add(Credit15);

            Certificates.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh);
            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh = Certificates[i++];
            //-

            //----------------------


            Certificate certificate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer = new Certificate();
            certificate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer.CreditList.Add(Credit1);

            Certificates.Add(certificate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer);
            certificate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer = Certificates[i++];
            //-

            Certificate certificate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar = new Certificate();
            certificate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar.CreditList.Add(Credit1);

            Certificates.Add(certificate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar);
            certificate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar = Certificates[i++];
            //-

            //? make decision
            Certificate certificate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer = new Certificate();
            certificate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer.CreditList.Add(Credit1);

            Certificates.Add(certificate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer);
            certificate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer = Certificates[i++];
            //-

            Certificate certificate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari = new Certificate();
            certificate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari.CreditList.Add(Credit1);

            Certificates.Add(certificate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari);
            certificate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari = Certificates[i++];
            //-

            //----------------------


            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri.CreditList.Add(Credit16);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri = Certificates[i++];
            //-

            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar.CreditList.Add(Credit17);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar = Certificates[i++];
            //-

            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn.CreditList.Add(Credit18);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn = Certificates[i++];
            //-

            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat.CreditList.Add(Credit19);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat = Certificates[i++];
            //-
            //----

            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama.CreditList.Add(Credit20);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama = Certificates[i++];
            //-


            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri.CreditList.Add(Credit21);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri = Certificates[i++];
            //-


            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi.CreditList.Add(Credit22);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi = Certificates[i++];
            //-


            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari.CreditList.Add(Credit23);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari = Certificates[i++];
            //-

            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat.CreditList.Add(Credit24);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat = Certificates[i++];
            //-


            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri.CreditList.Add(Credit25);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri = Certificates[i++];
            //-


            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati.CreditList.Add(Credit26);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati = Certificates[i++];
            //-

            Certificate certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh = new Certificate();
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh.CreditList.Add(Credit27);

            Certificates.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh);
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh = Certificates[i++];
            //-
            //----------------------

            #endregion

            #region level3


            Certificate certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake = new Certificate();
            certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake.CreditList.Add(Credit28);

            Certificates.Add(certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake);
            certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake = Certificates[i++];
            //-

            Certificate certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake = new Certificate();
            certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake.CreditList.Add(Credit29);

            Certificates.Add(certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake);
            certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake = Certificates[i++];
            //-

            Certificate certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri = new Certificate();
            certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri.CreditList.Add(Credit1);

            Certificates.Add(certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);
            certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri = Certificates[i++];
            //-

            //----------------------
            #endregion
            //--------------------------
            for (int k = 0; k < Certificates.Count; k++)
            {
                Certificate cer = Certificates[k];
                cer.Id = k;
            }

            #endregion

            i = 0;
            #region Fill CertificateList for all Gates

            Gate_root_dorooseOmoomiVaMaaref.CertificateList.Add(certificate_root_dorooseOmoomiVaMaaref);

            Gate_root_darsHayePaye.CertificateList.Add(certificate_root_darsHayePaye);

            Gate_root_darsHayeAsli.CertificateList.Add(certificate_root_darsHayeAsli);

            Gate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer.CertificateList.Add(certificate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer);

            Gate_root_darsHayeTamarkozHayeEkhtiari.CertificateList.Add(certificate_root_darsHayeTamarkozHayeEkhtiari);

            Gate_root_darsHayeEkhtiari.CertificateList.Add(certificate_root_darsHayeEkhtiari);

            //---------------------

            Gate_dorooseOmoomiVaMaaref_mabanieNazarieEslam.CertificateList.Add(certificate_dorooseOmoomiVaMaaref_mabanieNazarieEslam);

            Gate_dorooseOmoomiVaMaaref_akhlagheEslami.CertificateList.Add(certificate_dorooseOmoomiVaMaaref_akhlagheEslami);

            Gate_dorooseOmoomiVaMaaref_enghelabeEslami.CertificateList.Add(certificate_dorooseOmoomiVaMaaref_enghelabeEslami);

            Gate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami.CertificateList.Add(certificate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami);

            Gate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref.CertificateList.Add(certificate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref);

            Gate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami.CertificateList.Add(certificate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami);

            //---------------------

            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri
                .CertificateList.Add(certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar
                .CertificateList.Add(certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar);

            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn
                .CertificateList.Add(certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn);

            Gate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat
                .CertificateList.Add(certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat);

            //---------------------

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama
                .CertificateList.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama);


            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri
                .CertificateList.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi
                .CertificateList.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi);

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari
                .CertificateList.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari);


            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat
                .CertificateList.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri
                .CertificateList.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri);

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati
                .CertificateList.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati);

            Gate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh
                .CertificateList.Add(certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh);

            //---------------------

            Gate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer.CertificateList.Add(certificate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer);

            Gate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar.CertificateList.Add(certificate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar);

            Gate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .CertificateList.Add(certificate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer);

            Gate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari.CertificateList.Add(certificate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari);

            //---------------------

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri
                .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri);

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar
             .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar);

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn
             .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn);

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat
             .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat);

            //--            

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama
            .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama);

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri
                .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi
                .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi);

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari
                .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari);

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat
                .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat);

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri
                .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri);

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati
                .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati);

            Gate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh
                .CertificateList.Add(certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh);

            //---------------------

            Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake
                .CertificateList.Add(certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake);

            Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake
                .CertificateList.Add(certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake);

            Gate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri
                .CertificateList.Add(certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri);

            //---------------------

            #endregion

            i = 0;
            #region Constraint

            #region 1

            Constraint1 = new MinNumberMaxNumberOfCoursesConstraint
            {
                MinNumberOfCoursesMustBePass = 2,
                MaxNumberOfCoursesMustBePass = 2,
            };
            Constraints.Add(Constraint1);

            Constraint2 = new MinNumberMaxNumberOfCoursesConstraint
            {
                MinNumberOfCoursesMustBePass = 1,
                MaxNumberOfCoursesMustBePass = 1,
            };
            Constraints.Add(Constraint2);

            Constraint3 = new MinNumberMaxNumberOfCoursesConstraint
            {
                MinNumberOfCoursesMustBePass = 5,
                MaxNumberOfCoursesMustBePass = 5,
            };
            Constraints.Add(Constraint3);

            Constraint4 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 22,
                MaxUnitsOfCoursesMustBePass = 22,
            };
            Constraints.Add(Constraint4);

            //-------------------------
            Constraint5 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 20,
                MaxUnitsOfCoursesMustBePass = 20,
            };
            Constraints.Add(Constraint5);
            //-------------------------
            Constraint6 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 59,
                MaxUnitsOfCoursesMustBePass = 59,
            };
            Constraints.Add(Constraint6);
            //-------------------------
            Constraint7 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 19,
                MaxUnitsOfCoursesMustBePass = 31,
            };
            Constraints.Add(Constraint7);

            Constraint8 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 19,
                MaxUnitsOfCoursesMustBePass = 19,
            };
            Constraints.Add(Constraint8);

            Constraint9 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 31,
                MaxUnitsOfCoursesMustBePass = 31,
            };
            Constraints.Add(Constraint9);
            //-------------------------

            Constraint10 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 0,
                MaxUnitsOfCoursesMustBePass = 12,
            };
            Constraints.Add(Constraint10);

            Constraint11 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 9,
                MaxUnitsOfCoursesMustBePass = 9,
            };
            Constraints.Add(Constraint11);
            //-------------------------

            Constraint12 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 8,
                MaxUnitsOfCoursesMustBePass = 8,
            };
            Constraints.Add(Constraint12);

            Constraint13 = new NumberOfCoursesMustBeLabOrWorkshopConstraint
            {
                NumberOfCoursesMustBeLabOrWorkshop = 2,
            };
            Constraints.Add(Constraint13);
            //--

            Constraint14 = new NumberOfCoursesMustBeLabOrWorkshopConstraint
            {
                NumberOfCoursesMustBeLabOrWorkshop = 0,
            };
            Constraints.Add(Constraint14);

            Constraint15 = new MinNumberMaxNumberOfCoursesConstraint
            {
                MinNumberOfCoursesMustBePass = 0,
                MaxNumberOfCoursesMustBePass = 1,
            };
            Constraints.Add(Constraint15);

            Constraint16 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 3,
                MaxUnitsOfCoursesMustBePass = 3,
            };
            Constraints.Add(Constraint16);

            //--
            Constraint17 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 0,
                MaxUnitsOfCoursesMustBePass = 8,
            };
            Constraints.Add(Constraint17);
            //-------------------------
            Constraint18 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 12,
                MaxUnitsOfCoursesMustBePass = 12,
            };
            Constraints.Add(Constraint18);
            //-------------------------
            Constraint19 = new MinNumberMaxNumberOfCoursesConstraint
            {
                MinNumberOfCoursesMustBePass = 0,
                MaxNumberOfCoursesMustBePass = 2,
            };
            Constraints.Add(Constraint19);
            //-------------------------
            Constraint20 = new MinUnitsMaxUnitsOfCoursesConstraint
            {
                MinUnitsOfCoursesMustBePass = 20,
                MaxUnitsOfCoursesMustBePass = 20,
            };
            Constraints.Add(Constraint19);
            //-------------------------
            Constraint21 = new UnitOfCoursesMustBeLabOrWorkshopConstraint
            {
                UnitOfCoursesMustBeLabOrWorkshop = 2,
            };
            Constraints.Add(Constraint19);

            #endregion
            //-------------------------
            for (int k = 0; k < Constraints.Count; k++)
            {
                Constraint cons = Constraints[k];
                cons.Id = k;
            }
            #endregion

            i = 0;
            #region Fill Certificate Rel Constraint

            certificate_root_dorooseOmoomiVaMaaref.ConstraintList.Add(Constraint4);

            certificate_root_darsHayePaye.ConstraintList.Add(Constraint20);

            certificate_root_darsHayeAsli.ConstraintList.Add(Constraint6);

            certificate_root_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer.ConstraintList.Add(Constraint7);

            certificate_root_darsHayeTamarkozHayeEkhtiari.ConstraintList.Add(Constraint18);

            certificate_root_darsHayeEkhtiari.ConstraintList.Add(Constraint12);
            certificate_root_darsHayeEkhtiari.ConstraintList.Add(Constraint13);
            certificate_root_darsHayeEkhtiari.ConstraintList.Add(Constraint21);

            //----------------------

            certificate_dorooseOmoomiVaMaaref_mabanieNazarieEslam.ConstraintList.Add(Constraint1);

            certificate_dorooseOmoomiVaMaaref_akhlagheEslami.ConstraintList.Add(Constraint2);

            certificate_dorooseOmoomiVaMaaref_enghelabeEslami.ConstraintList.Add(Constraint2);

            certificate_dorooseOmoomiVaMaaref_tarikhOtamadoneEslami.ConstraintList.Add(Constraint2);

            certificate_dorooseOmoomiVaMaaref_khateTire_dorooseOmoomiVaMaaref.ConstraintList.Add(Constraint3);

            certificate_dorooseOmoomiVaMaaref_ashnaieBaManabeEslami.ConstraintList.Add(Constraint2);

            //----------------------

            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri
                .ConstraintList.Add(Constraint8);

            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheNarmafzar
                .ConstraintList.Add(Constraint8);

            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheRayanesheAmn
                .ConstraintList.Add(Constraint9);

            certificate_darsHayeTakhassosieGerayeshHayeChaahrGanehReshteMohandesiComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat
                .ConstraintList.Add(Constraint9);

            //----------------------

            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeMojtama
                .ConstraintList.Add(Constraint18);

            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieShabakeHayeComputeri
                .ConstraintList.Add(Constraint18);

            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieHoosheMasnooi
                .ConstraintList.Add(Constraint18);

            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeNarmafzari
                .ConstraintList.Add(Constraint18);

            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat
                .ConstraintList.Add(Constraint18);

            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieBaziHayeComputeri
                .ConstraintList.Add(Constraint18);

            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieSystemHayeEttelaati
                .ConstraintList.Add(Constraint18);

            certificate_darsHayeTamarkozHayeEkhtiari_darsHayeTamarkozTakhassosieAmniateRayaneh
                .ConstraintList.Add(Constraint18);

            //----------------------

            certificate_darsHayeEkhtiari_darseEkhtiariAzArshadeComputer
                .ConstraintList.Add(Constraint2);

            certificate_darsHayeEkhtiari_darseEkhtiariAzKarshenasieDaneshkadehHayeDigar
                .ConstraintList.Add(Constraint2);

            certificate_darsHayeEkhtiari_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer
                .ConstraintList.Add(Constraint17);

            certificate_darsHayeEkhtiari_khateTire_darsHayeEkhtiari
                .ConstraintList.Add(Constraint17);

            //----------------------

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheMemarieSystemHayeComputeri
                .ConstraintList.Add(Constraint17);

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheNarmafzar
                .ConstraintList.Add(Constraint17);

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheRayanesheAmn
                .ConstraintList.Add(Constraint17);

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTakhasosieGerayesheFanavarieEttelaat
                .ConstraintList.Add(Constraint17);

            //----------------------
            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeMojtama
                .ConstraintList.Add(Constraint17);

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieShabakeHayeComputeri
                .ConstraintList.Add(Constraint17);

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieHoosheMasnooi
                .ConstraintList.Add(Constraint17);

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeNarmafzari
                .ConstraintList.Add(Constraint17);

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAlgorithmVaMohasebat
                .ConstraintList.Add(Constraint17);

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieBaziHayeComputeri
                .ConstraintList.Add(Constraint17);

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieSystemHayeEttelaati
                .ConstraintList.Add(Constraint17);

            certificate_taHastVahedAzDarsHayeGerayeshHaYaTamarkozHayeDigareMohandesieComputer_darsHayeTamarkozTakhassosieAmniateRayaneh
                .ConstraintList.Add(Constraint17);
            //----------------------

            //certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseNarmafzarBareTakhasosieShabake
            //    .ConstraintList.Add(constraint2);

            //certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_basteMakhsooseSakhtAfzarBareTakhasosieShabake
            //    .ConstraintList.Add(constraint2);

            //certificate_darsHayeTamarkozTakhassosieShabakeHayeComputeri_khateTire_darsHayeTamarkozTakhassosieShabakeHayeComputeri
            //    .ConstraintList.Add(constraint11);

            //----------------------

            #endregion

        }
        #endregion

    }
}
