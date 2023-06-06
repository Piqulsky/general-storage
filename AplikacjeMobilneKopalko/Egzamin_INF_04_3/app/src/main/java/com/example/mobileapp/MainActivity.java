package com.example.mobileapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private String s = "";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    /*
    ***********************************************
    nazwa funkcji: OK
    argumenty: view - element activity, który wywołał funkcję
    typ zwracany: void
    informacje: funkcja OK powoduje wywołanie nowego activity z przekazanym mu stringiem "pin"
    * i przygotowuje activity do powrotu
    autor: Michał Pikulski
    ****************************************************
     */
    public void OK(View view){
        Intent i = new Intent(this, LoggedActivity.class);
        i.putExtra("pin", s);
        startActivity(i);
        s = "";
        findViewById(R.id.okButton).setEnabled(false);
    }
    /*
    ***********************************************
    nazwa funkcji: CLR
    argumenty: view - element activity, który wywołał funkcję
    typ zwracany: void
    informacje: funkcja CLR czyści string s i wyłącza przycisk OK
    autor: Michał Pikulski
    ****************************************************
     */
    public void CLR(View view){
        s = "";
        findViewById(R.id.okButton).setEnabled(false);
    }
    /*
    ***********************************************
    nazwa funkcji: inputNumber
    argumenty: view - element activity, który wywołał funkcję
    typ zwracany: void
    informacje: funkcja inputNumber dodaje tekst z przycisku który ją wywołał
    (we wszystkich przypadkach - pojedynczą liczbę) do stringa s, a potem
    sprawdza długość stringa s, żeby albo włączyć przycisk OK, albo wywołać funckję OK
    autor: Michał Pikulski
    ****************************************************
     */
    public void inputNumber(View view){
        Button b = (Button) view;
        s += b.getText();
        if(s.length() > 3){
            findViewById(R.id.okButton).setEnabled(true);
        }
        if(s.length() > 5){
            OK(b.getRootView());
        }
    }
}