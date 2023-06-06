package com.example.mobilnaexam5;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        getSupportActionBar().setTitle("Dane osobowe");
    }

    /************************************************
    nazwa funkcji: submitForm
    argumenty: view View - widok aplikacji
    typ zwracany: void
    informacje: funkcja obsługuje akceptację formularza
    autor: Bastian Wierzchnicki
    ****************************************************/

    public void submitForm(View view) {
        EditText surname_input = findViewById(R.id.surnameInput);
        EditText name_input = findViewById(R.id.nameInput);
        RadioButton woman_input = findViewById(R.id.radio_kobieta);
        RadioButton man_input = findViewById(R.id.radio_facet);

        String surname = String.valueOf(surname_input.getText());
        String name = String.valueOf(name_input.getText());
        String gender = "Nie podano";

        if(surname.isEmpty() || name.isEmpty()) return;

        if(woman_input.isChecked()) gender = String.valueOf(woman_input.getText());
        else if(man_input.isChecked()) gender = String.valueOf(man_input.getText());

        Intent myIntent = new Intent(MainActivity.this, DetailsActivity.class);
        myIntent.putExtra("dane", new String[]{surname, name, gender});
        startActivity(myIntent);
    }
}