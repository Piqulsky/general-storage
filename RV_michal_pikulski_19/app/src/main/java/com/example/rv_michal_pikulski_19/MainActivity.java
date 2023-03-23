package com.example.rv_michal_pikulski_19;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    private ItemAdapter itemAdapter;
    private List<TransactionData> data;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        RecyclerView recyclerView = (RecyclerView) findViewById(R.id.recyclerView);
        data = createData();
        itemAdapter = new ItemAdapter(data);
        recyclerView.setAdapter(itemAdapter);
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

    public void OnClick(View view){
        EditText editText1 = findViewById(R.id.editText1);
        EditText editText2 = findViewById(R.id.editText2);
        if(editText1.getText().equals("") || editText2.getText().equals("")) return;
        data.add(new TransactionData(editText1.getText().toString(), editText2.getText().toString()));
        itemAdapter.notifyDataSetChanged();
    }
}