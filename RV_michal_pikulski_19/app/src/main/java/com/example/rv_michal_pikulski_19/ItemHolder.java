package com.example.rv_michal_pikulski_19;

import android.view.View;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

public class ItemHolder extends RecyclerView.ViewHolder {
    private final TextView textView;
    private final TextView secondTextView;

    public ItemHolder(@NonNull View itemView) {
        super(itemView);
        textView = (TextView) itemView.findViewById(R.id.viewText);
        secondTextView = (TextView) itemView.findViewById(R.id.secondViewText);
    }

    public TextView getTextView() {
        return textView;
    }
    public TextView getSecondaryTextView() {
        return secondTextView;
    }
}
