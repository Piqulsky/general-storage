package com.example.rv_michal_pikulski_19;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

public class ItemAdapter extends RecyclerView.Adapter<ItemHolder> {
    public ItemAdapter(List<TransactionData> list){
        dataStore = list;
    }
    private List<TransactionData> dataStore;

    @NonNull
    @Override
    public ItemHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.activity_recycler_item, parent, false);
        return new ItemHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull ItemHolder holder, int position) {
        holder.getTextViewName().setText(dataStore.get(position).name);
        holder.getTextViewOccurrence().setText(dataStore.get(position).occurrence);
        holder.getTextEating().setText(dataStore.get(position).eating);
        holder.getTextViewEnvironment().setText(dataStore.get(position).environment);
        holder.getTextViewLifespan().setText(dataStore.get(position).lifespan);
        holder.getImageView().setImageResource(dataStore.get(position).image);
    }

    @Override
    public int getItemCount() {
        return dataStore.size();
    }
}
