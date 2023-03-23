package com.example.rv_michal_pikulski_19;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        RecyclerView recyclerView = (RecyclerView) findViewById(R.id.recyclerView);
        ItemAdapter adapter = new ItemAdapter(createData());
        recyclerView.setAdapter(adapter);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
    }

    List<TransactionData> createData(){
        List<TransactionData> localDataStore = new ArrayList<TransactionData>();
        localDataStore.add(new TransactionData("Alfa", "Ena"));
        localDataStore.add(new TransactionData("Beta", "Dio"));
        localDataStore.add(new TransactionData("Gamma", "Tria"));
        localDataStore.add(new TransactionData("Delta", "Tessera"));
        localDataStore.add(new TransactionData("Epsilon", "Pente"));
        localDataStore.add(new TransactionData("Dzeta", "Exi"));
        localDataStore.add(new TransactionData("Eta", "Epta"));
        localDataStore.add(new TransactionData("Theta", "Okto"));
        localDataStore.add(new TransactionData("Jota", "Ennia"));
        localDataStore.add(new TransactionData("Kappa", "Deka"));
        localDataStore.add(new TransactionData("Lambda", "Enteka"));
        localDataStore.add(new TransactionData("My", "Dodeka"));
        return localDataStore;
    }
}