String intToRoman(int num) {
    String romanNumeral = "";
    for(int i = 0; i < num - (num % 1000); i+=1000) romanNumeral += "M";
    num = (num % 1000);
    for(int i = 0; i < num - (num % 900); i+=900) romanNumeral += "CM";
    num = (num % 900);
    for(int i = 0; i < num - (num % 500); i+=500) romanNumeral += "D";
    num = (num % 500);
    for(int i = 0; i < num - (num % 400); i+=400) romanNumeral += "CD";
    num = (num % 400);
    for(int i = 0; i < num - (num % 100); i+=100) romanNumeral += "C";
    num = (num % 100);
    for(int i = 0; i < num - (num % 90); i+=90) romanNumeral += "XC";
    num = (num % 90);
    for(int i = 0; i < num - (num % 50); i+=50) romanNumeral += "L";
    num = (num % 50);
    for(int i = 0; i < num - (num % 40); i+=40) romanNumeral += "XL";
    num = (num % 40);
    for(int i = 0; i < num - (num % 10); i+=10) romanNumeral += "X";
    num = (num % 10);
    for(int i = 0; i < num - (num % 9); i+=9) romanNumeral += "IX";
    num = (num % 9);
    for(int i = 0; i < num - (num % 5); i+=5) romanNumeral += "V";
    num = (num % 5);
    for(int i = 0; i < num - (num % 4); i+=4) romanNumeral += "IV";
    num = (num % 4);
    for(int i = 0; i < num - (num % 1); i+=1) romanNumeral += "I";

    return romanNumeral;
}

int romanToInt(String s) {
    int total = 0;
    int currentNum = 0;
    
    for(int i = 0; i < s.length() - 1; i++){
        currentNum = numeralToInt(s.charAt(i));

        if(numeralToInt(s.charAt(i + 1)) > currentNum) total -= currentNum;
        else total += currentNum;
    }

    total += numeralToInt(s.charAt(s.length() - 1));
    return total;
}

int numeralToInt(char c){
    switch(c){
        case 'I':
            return 1;
        case 'V':
            return 5;
        case 'X':
            return 10;
        case 'L':
            return 50;
        case 'C':
            return 100;
        case 'D':
            return 500;
        case 'M':
            return 1000;
        default:
            return -1;
    }
}