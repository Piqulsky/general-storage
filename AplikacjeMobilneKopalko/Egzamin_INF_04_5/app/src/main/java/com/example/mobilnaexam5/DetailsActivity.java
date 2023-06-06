package com.example.mobilnaexam5;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

public class DetailsActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_details2);
        getSupportActionBar().setTitle("Dane osobowe");
        String[] data = getIntent().getStringArrayExtra("dane");
        TextView nameArea = findViewById(R.id.nameArea);
        TextView genderArea = findViewById(R.id.genderArea);

        String name = data[0] + " " + data[1];
        nameArea.setText(name);
        genderArea.setText(data[2]);
    }
}