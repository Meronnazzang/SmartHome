#include <SPI.h>
#include <MFRC522.h>

MFRC522 mfrc(PIN_RFID_SS,PIN_RFID_RST);

const byte UID_PASS[4] = {211, 55, 47, 149};
bool opened = false;
int count_opened = 0;

void setup_lock_main()
{
    SPI.begin();
    mfrc.PCD_Init();
    pinMode(PIN_RELAY_LOCK_MAIN, OUTPUT);
}

void task_lock_main()
{
    if (escape);
    else
    {
        bool uid_check = false;
    
        if(mfrc.PICC_IsNewCardPresent() && mfrc.PICC_ReadCardSerial())
        {
            Serial.println("/////////////////////////Card detected/////////////////////////");
            uid_check = true;
            for (int i=0; i<4; i++)
            { 
                byte uid = mfrc.uid.uidByte[i];
                Serial.print(uid);
                Serial.print(" ");
                uid_check = uid_check && (uid == UID_PASS[i]);
            }
            Serial.println();

            if(uid_check)
            {
                Serial.println("/////////////////////////Door open/////////////////////////");
                digitalWrite(PIN_RELAY_LOCK_MAIN, HIGH);
                opened = true;
                count_opened = 0;
            }
        }
        else
        {
            Serial.println("/////////////////////////No card/////////////////////////");
            if (opened)
            {
                count_opened++;
                if (count_opened >= 20)
                {
                    digitalWrite(PIN_RELAY_LOCK_MAIN, LOW); // LOW가 들어가면 카드 인식 잘 안 됨
                    opened = false;
                    count_opened = 0;
                }
            }
            else
            {
                digitalWrite(PIN_RELAY_LOCK_MAIN, LOW);
            }
        }
    }
}
