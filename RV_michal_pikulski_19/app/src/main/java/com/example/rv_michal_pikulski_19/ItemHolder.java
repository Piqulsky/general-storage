package com.example.rv_michal_pikulski_19;

import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

public class ItemHolder extends RecyclerView.ViewHolder {
    private final TextView textViewName;
    private final TextView textViewOccurrence;
    private final TextView textViewEating;
    private final TextView textViewEnvironment;
    private final TextView textViewLifespan;
    private final ImageView imageView;

    public ItemHolder(@NonNull View itemView) {
        super(itemView);
        textViewName = itemView.findViewById(R.id.textViewName);
        textViewOccurrence = itemView.findViewById(R.id.textViewOccurrence);
        textViewEating = itemView.findViewById(R.id.textViewEating);
        textViewEnvironment = itemView.findViewById(R.id.textViewEnvironment);
        textViewLifespan = itemView.findViewById(R.id.textViewLifespan);
        imageView = itemView.findViewById(R.id.imageView);
    }

    public TextView getTextViewName() {
        return textViewName;
    }
    public TextView getTextViewOccurrence() {
        return textViewOccurrence;
    }
    public TextView getTextEating() {
        return textViewEating;
    }
    public TextView getTextViewEnvironment() {
        return textViewEnvironment;
    }
    public TextView getTextViewLifespan() {
        return textViewLifespan;
    }
    public ImageView getImageView() {
        return imageView;
    }
}
