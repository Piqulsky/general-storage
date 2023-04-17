package com.example.rv_michal_pikulski_19;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import java.util.ArrayList;
import java.util.Dictionary;
import java.util.List;
import java.util.Map;

public class MainActivity extends AppCompatActivity {
    private ItemAdapter itemAdapter;
    private List<TransactionData> data;

    Map<Integer, String[]> processableData;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        RecyclerView recyclerView = findViewById(R.id.recyclerView);
        data = createData();
        itemAdapter = new ItemAdapter(data);
        recyclerView.setAdapter(itemAdapter);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
    }

    List<TransactionData> createData(){
        List<TransactionData> localDataStore = new ArrayList<TransactionData>();
        return localDataStore;
    }
}