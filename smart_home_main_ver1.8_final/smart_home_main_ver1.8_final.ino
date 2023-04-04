#include "pins.h"
#include "buzzer.h"
#include "dht.h"
#include "distance.h"
#include "door_bell.h"
#include "flame_gas.h"
#include "led_bar.h"
#include "lock_main.h"
#include "lock_sub.h"
#include "motion.h"
#include "water.h"

void setup()
{
    Serial.begin(9600);
    
    setup_dht();
    setup_distance();
    setup_door_bell();
    setup_flame_gas();
    setup_led_bar();
    setup_lock_main();
    setup_lock_sub();
    setup_water();

    setup_buzzer();     // 타이머/카운터
    setup_motion();     // 외부 인터럽트
    sei();              // 인터럽트 활성화
}

void loop()
{
    task_dht();
    task_distance();
    task_door_bell();
    task_flame_gas();
    task_led_bar();
    task_lock_main();
    task_lock_sub();
    task_water();
    
    delay(100);
}
