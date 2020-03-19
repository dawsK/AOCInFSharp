open System

type DayPart =
  | Morning
  | Afternoon
  | Evening
  | Night

type Language =   
  | German 
  | Hausa 
  | Hebrew 
  | Russian 
  | Ukranian 
  | Bangla 
  | Mandarin 
  | CSharp  
  | Portuguese 
  | Nepali
  | Tagalog
  | English
  | French

let getGreeting language dayPart = 
    match (language, dayPart) with
        | (German, Morning) -> "Guten Morgen"
        | (German, Afternoon) -> "Guten Tag"
        | (German, Evening) -> "Guten Abend"
        | (German, Night) -> "Gute Nacht"
        
        | (Hausa, Morning) -> "Ina Kwana"
        | (Hausa, Afternoon) -> "Barka da Rana"
        | (Hausa, Evening) -> "Barka da yamma"
        | (Hausa, Night) -> "Dare mai Kyau"

        | (Hebrew, Morning) -> "בוקר טוב"
        | (Hebrew, Afternoon) -> "אחר הצהריים טובים"
        | (Hebrew, Evening) -> "ערב טוב"
        | (Hebrew, Night) -> "לילה טוב"

        | (Russian, Morning) -> "Доброе утро"
        | (Russian, Afternoon) -> "Добрый день"
        | (Russian, Evening) -> "Добрый вечер"
        | (Russian, Night) -> "Доброй ночи"
        
        | (Ukranian, Morning) -> "Добрий ранок"
        | (Ukranian, Afternoon) -> "Доброго дня"
        | (Ukranian, Evening) -> "Доброго вечор"
        | (Ukranian, Night) -> "Надобраніч"

        | (Bangla, Morning) -> "সুপ্রভাত"
        | (Bangla, Afternoon) -> "শুভ অপরাহ্ন"
        | (Bangla, Evening) -> "শুভ সন্ধ্যা"
        | (Bangla, Night) -> "শুভ রাত্রি"

        | (Mandarin, Morning) -> "早上好"
        | (Mandarin, Afternoon) -> "下午好"
        | (Mandarin, Evening) -> "晚上好"
        | (Mandarin, Night) -> "晚安"

        | (CSharp, Morning)  -> "Console.WriteLine(\"Good Morning World!\");"
        | (CSharp, Afternoon)  -> "Console.WriteLine(\"Good Afternoon World!\");"
        | (CSharp, Evening)  -> "Console.WriteLine(\"Good Evening World!\");"
        | (CSharp, Night)  -> "Console.WriteLine(\"Good Night World!\");"

        | (Portuguese, Morning)  -> "Bom dia"
        | (Portuguese, Afternoon)  -> "Boa tarde"
        | (Portuguese, Evening)  -> "Boa noite"
        | (Portuguese, Night)  -> "Boa noite"

        | (Nepali, Morning) -> "शुभ प्रभात"
        | (Nepali, Afternoon) -> "नमस्कार"
        | (Nepali, Evening) -> "सुसंध्या"
        | (Nepali, Night) -> "शुभ रात्रि"

        | (Tagalog, Morning) -> "Magandang Umaga"
        | (Tagalog, Afternoon) -> "Magandang hapon"
        | (Tagalog, Evening) -> "Magandang gabi"
        | (Tagalog, Night) -> "Magandang gabi"c

        | (English, Morning) -> "Good morning"
        | (English, Afternoon) -> "Good afternoon"
        | (English, Evening) -> "Good evening"
        | (English, Night) -> "Good night" 

        | (French, Morning) -> "Bon matin"
        | (French, Afternoon) -> "Bonjour"
        | (French, Evening) -> "Bon nuit"
        | (French, Night) -> "Bon nuit"
        
 
let getDayPart (time:DateTime) =
  match time.Hour with
  | hour when hour < 4 -> Night
  | hour when hour < 12 -> Morning
  | hour when hour < 18 -> Afternoon
  | _ -> Night

let getCurrentGreeting language = getDayPart DateTime.Now |> getGreeting language

getCurrentGreeting French |> Console.WriteLine

// https://repl.it/repls/EnlightenedVibrantFrontpage