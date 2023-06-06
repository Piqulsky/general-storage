package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    private List<String> list = new ArrayList<>();
    private ArrayAdapter listAdapter;
    /*
    ***********************************************
    nazwa funkcji: onCreate
    argumenty: savedInstanceState - domyślny argument
    typ zwracany: brak
    informacje: funkcja tworzy aplikację, dodaje bazowe elementy do listy, tworzy adapter do listView
    autor: Michał Pikulski
    ****************************************************
    */
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        list.add("Zakupy: mleko, masło");
        list.add("Ugotować obiad");
        list.add("Sobota: kino");
        ListView listView = findViewById(R.id.listView);
        listAdapter = new ArrayAdapter(this, R.layout.item, list);
        listView.setAdapter(listAdapter);
    }
    /*
    ***********************************************
    nazwa funkcji: OnClick
    argumenty: view - wymagany argument dla funkcji
    typ zwracany: brak
    informacje: funkcja dodaje wartość do listy, wysyła powiadomienie o zmianie do adaptera
    autor: Michał Pikulski
    ****************************************************
    */
    public void OnClick(View view){
        EditText textView = findViewById(R.id.editText);
        list.add(textView.getText().toString());
        listAdapter.notifyDataSetChanged();
    }
}