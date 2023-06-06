package com.example.mobileapp;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class LoggedActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_logged);

        Bundle extras = getIntent().getExtras();
        ((TextView) findViewById(R.id.textView3)).setText(extras.getString("pin"));
    }
    /*
    ***********************************************
    nazwa funkcji: back
    argumenty: view - element activity, który wywołał funkcję
    typ zwracany: void
    informacje: funkcja back powoduje powrót do poprzedniego activity
    autor: Michał Pikulski
    ****************************************************
     */
    public void back(View view){
        finish();
    }
}