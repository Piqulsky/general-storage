package com.example.listviewcustom;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ListView;

public class MainActivity extends AppCompatActivity
{
    String [] countries = {"USA", "UK", "SPAIN", "POLAND", "CZECH"};
    int [] flags = {R.drawable.usa, R.drawable.uk, R.drawable.spain, R.drawable.poland, R.drawable.czech};

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Adapter adapter = new Adapter(getApplicationContext(),countries,flags);
        ListView lv = findViewById(R.id.listView);
        lv.setAdapter(adapter);

    }
}