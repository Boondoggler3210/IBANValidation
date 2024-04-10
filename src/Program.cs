using IBANValidation.CheckCharacterSystems;
using IBANValidation.Validators.BIC;
using IBANValidation.Validators.GlobalLocationNumber;
using IBANValidation.Validators.IBAN;
using IBANValidation.Validators.NOOrganisasjonsnummer;
using IBANValidation.Validators.RFCreditorReference;
using IBANValidation.Validators.TaxIdentificationNumbers.UKVATRegistrationNumber;
using IBANValidation.Validators.USRoutingNumber;

var ibans =  new List<string>(){"AD1200012030200359100100",
"AE070331234567890123456",
"AL47212110090000000235698741",
"AT611904300234573201",
"AZ21NABZ00000000137010001944",
"BA391290079401028494",
"BE68539007547034",
"BG80BNBG96611020345678",
"BH67BMAG00001299123456",
"BI4210000100010000332045181",
"BR1800360305000010009795493C1",
"BY13NBRB3600900000002Z00AB00",
"CH9300762011623852957",
"CR05015202001026284066",
"CY17002001280000001200527600",
"CZ6508000000192000145399",
"DE89370400440532013000",
"DJ2100010000000154000100186",
"DK5000400440116243",
"DO28BAGR00000001212453611324",
"EE382200221020145685",
"EG380019000500000000263180002",
"ES9121000418450200051332",
"FI2112345600000785",
"FK88SC123456789012",
"FO6264600001631634",
"FR1420041010050500013M02606",
"GB29NWBK60161331926819",
"GE29NB0000000101904917",
"GI75NWBK000000007099453",
"GL8964710001000206",
"GR1601101250000000012300695",
"GT82TRAJ01020000001210029690",
"HR1210010051863000160",
"HU42117730161111101800000000",
"IE29AIBK93115212345678",
"IL620108000000099999999",
"IQ98NBIQ850123456789012",
"IS140159260076545510730339",
"IT60X0542811101000000123456",
"JO94CBJO0010000000000131000302",
"KW81CBKU0000000000001234560101",
"KZ86125KZT5004100100",
"LB62099900000001001901229114",
"LC55HEMM000100010012001200023015",
"LI21088100002324013AA",
"LT121000011101001000",
"LU280019400644750000",
"LV80BANK0000435195001",
"LY83002048000020100120361",
"MC5811222000010123456789030",
"MD24AG000225100013104168",
"ME25505000012345678951",
"MK07250120000058984",
"MN121234123456789123",
"MR1300020001010000123456753",
"MT84MALT011000012345MTLCAST001S",
"MU17BOMM0101101030300200000MUR",
"NI04BAPR00000013000003558124",
"NL91ABNA0417164300",
"NO9386011117947",
"OM810180000001299123456",
"PK36SCBL0000001123456702",
"PL61109010140000071219812874",
"PS92PALS000000000400123456702",
"PT50000201231234567890154",
"QA58DOHB00001234567890ABCDEFG",
"RO49AAAA1B31007593840000",
"RS35260005601001611379",
"RU1704452522540817810538091310419",
"SA0380000000608010167519",
"SC18SSCB11010000000000001497USD",
"SD2129010501234001",
"SE4550000000058398257466",
"SI56263300012039086",
"SK3112000000198742637541",
"SM86U0322509800000000270100",
"SO211000001001000100141",
"ST23000100010051845310146",
"SV62CENR00000000000000700025",
"TL380080012345678910157",
"TN5910006035183598478831",
"TR330006100519786457841326",
"UA213223130000026007233566001",
"VA59001123000012345678",
"VG96VPVG0000012345678901",
"XK051212012345678906"
};

Console.WriteLine("IBAN Validation");
IbanValidator validator = new IbanValidator();

foreach(var iban in ibans)
{
    var res = validator.Validate(iban);
    if(res.IsValid == false){
        
        Console.WriteLine();
        Console.WriteLine($"{iban}: Validation result: {res.IsValid}");
        Console.WriteLine("Errors:");
        foreach(var error in res.Errors)
        {
            Console.WriteLine($"{error.Code}: {error.Message}");
        }
    }

}

Console.WriteLine();
Console.WriteLine("BIC Validation");
BicValidator bicValidator = new BicValidator();

var bicRes = bicValidator.Validate("RABOZZ2U");

Console.WriteLine(bicRes.IsValid);
foreach(var error in bicRes.Errors)
{
    Console.WriteLine(error.Code);
    Console.WriteLine(error.Message);
}


Console.WriteLine();
Console.WriteLine("RFCreditorReference Validation");
RFCreditorReferenceValidator rFCreditorReferenceValidator = new RFCreditorReferenceValidator();

var rFCreditorReferenceRes = rFCreditorReferenceValidator.Validate("RF18539007547034");
Console.WriteLine(rFCreditorReferenceRes.IsValid);
foreach(var error in rFCreditorReferenceRes.Errors)
{
    Console.WriteLine(error.Code);
    Console.WriteLine(error.Message);
}


Console.WriteLine();
Console.WriteLine("US Routing Number Validation");
var usRoutingNumberValidation = new USRoutingNumberValidator().Validate("789456124");
Console.WriteLine(usRoutingNumberValidation.IsValid);
foreach(var error in usRoutingNumberValidation.Errors)
{
    Console.WriteLine(error.Code);
    Console.WriteLine(error.Message);
}

Console.WriteLine();
Console.WriteLine("US Routing Number Check Character Calculation");
var usRoutingNumberCheckCharacter = new USRoutingNumberValidator().CalculateCheckCharacters("08100021");
Console.WriteLine(usRoutingNumberCheckCharacter);


Console.WriteLine();
Console.WriteLine("UK VAT Registration Number Validation");
//var uKVATRegistrationNumberValidation = new UKVATRegistrationNumberValidator().Validate("GB 339 0727 47");
var uKVATRegistrationNumberValidation = new UKVATRegistrationNumberValidator().Validate("GBHA951");
Console.WriteLine(uKVATRegistrationNumberValidation.IsValid);
foreach(var error in uKVATRegistrationNumberValidation.Errors)
{
    Console.WriteLine(error.Code);
    Console.WriteLine(error.Message);
}



Console.WriteLine();
Console.WriteLine("Global Location Number Check Character Calculation");
var globalLocationNumberValidation = new GlobalLocationNumberValidator().Validate("0847976000005"); 
Console.WriteLine(globalLocationNumberValidation.IsValid);
foreach(var error in globalLocationNumberValidation.Errors)
{
    Console.WriteLine(error.Code);
    Console.WriteLine(error.Message);
}

Console.WriteLine();
Console.WriteLine("Norwegian Organisasjonsnummer Check Character Calculation");
var nOOrganisasjonsnummerValidation = new NOOrganisasjonsnummerValidator().Validate("913965639");
Console.WriteLine(nOOrganisasjonsnummerValidation.IsValid);
foreach (var error in nOOrganisasjonsnummerValidation.Errors)
{
    Console.WriteLine(error.Code);
    Console.WriteLine(error.Message);
}


var luhn = new Luhn();
Console.WriteLine(luhn.Calculate("556667475"));
Console.WriteLine(luhn.Validate("5566674758"));