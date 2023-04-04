#include <DHT.h>
#include <LiquidCrystal_I2C.h>

DHT dht(PIN_DHT, DHT11);
LiquidCrystal_I2C lcd(0x27, 16, 2);

bool aircon_on = false;

void setup_dht()
{
    dht.begin();
    lcd.init();
    pinMode(PIN_DHT, INPUT);
    pinMode(PIN_RELAY_AIRCON, OUTPUT);
}

void task_dht()
{
    float temperature = dht.readTemperature();
    float humidity = dht.readHumidity();
    float heat_index = dht.computeHeatIndex(temperature, humidity, false);

    Serial.println("T:" + String(temperature) + "," + String(humidity) + "," + String(heat_index));
    
    lcd.backlight();
    lcd.setCursor(0,0);
    lcd.print("Tmp: " + String(temperature) + "`C");
    lcd.setCursor(0,1);
    lcd.print("Hum: " + String(humidity) + "%");

    if (heat_index > 27)
    {
        digitalWrite(PIN_RELAY_AIRCON, HIGH);
        aircon_on = true;
    }
    else
    {
        if (aircon_on)
        {
            if (heat_index < 23)
            {
                digitalWrite(PIN_RELAY_AIRCON, LOW);
                aircon_on = false;
            }
        }
    }
}
