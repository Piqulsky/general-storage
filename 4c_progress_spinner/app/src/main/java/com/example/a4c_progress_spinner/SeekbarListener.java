package com.example.a4c_progress_spinner;

import android.widget.ProgressBar;
import android.widget.SeekBar;

public class SeekbarListener implements SeekBar.OnSeekBarChangeListener {
    private ProgressBar progressBar;
    public SeekbarListener(ProgressBar progressBar){
        this.progressBar = progressBar;
    }

    @Override
    public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
        progressBar.setProgress(seekBar.getProgress());
    }

    @Override
    public void onStartTrackingTouch(SeekBar seekBar) {

    }

    @Override
    public void onStopTrackingTouch(SeekBar seekBar) {

    }
}
