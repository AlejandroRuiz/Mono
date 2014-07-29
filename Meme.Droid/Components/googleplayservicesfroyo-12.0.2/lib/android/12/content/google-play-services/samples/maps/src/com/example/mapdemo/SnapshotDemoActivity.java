// Copyright 2013 Google Inc. All Rights Reserved.

package com.example.mapdemo;

import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.GoogleMap.SnapshotReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;

import android.graphics.Bitmap;
import android.os.Bundle;
import android.support.v4.app.FragmentActivity;
import android.view.View;
import android.widget.ImageView;

/**
 * This shows how to take a snapshot of the map.
 */
public class SnapshotDemoActivity extends FragmentActivity {

    /**
     * Note that this may be null if the Google Play services APK is not available.
     */
    private GoogleMap mMap;

    /**
     * Same bitmap used to store all the snapshots.
     */
    private Bitmap mSnapshot;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.snapshot_demo);
        createMapIfReady();
    }

    @Override
    protected void onResume() {
        super.onResume();
        createMapIfReady();
    }

    private void createMapIfReady() {
        // Do a null check to confirm that we have not already instantiated the map.
        if (mMap == null) {
            // Try to obtain the map from the SupportMapFragment.
            SupportMapFragment mapFragment =
                    (SupportMapFragment) getSupportFragmentManager().findFragmentById(R.id.map);
            mMap = mapFragment.getMap();
        }
    }

    /**
     * Called when the snapshot button is clicked.
     */
    public void onScreenshot(View view) {
        if (mMap == null) {
            return;
        }

        final ImageView snapshotHolder = (ImageView) findViewById(R.id.snapshot_holder);

        SnapshotReadyCallback callback = new SnapshotReadyCallback() {
            @Override
            public void onSnapshotReady(Bitmap snapshot) {
                // Callback is called from the main thread, so we can modify the ImageView safely.
                snapshotHolder.setImageBitmap(snapshot);
                // Use the same bitmap for the following snapshots.
                mSnapshot = snapshot;
            }
        };

        // mSnapshot is null on the first call. It is then set in the callback to reuse the same
        // Bitmap object for all the following snapshots thus avoiding creating a new bitmap for
        // every snapshot.
        mMap.snapshot(callback, mSnapshot);
    }


    /**
     * Called when the clear button is clicked.
     */
    public void onClearScreenshot(View view) {
        ImageView snapshotHolder = (ImageView) findViewById(R.id.snapshot_holder);
        snapshotHolder.setImageDrawable(null);
    }

}
