#!/bin/bash

# export PATH=$PATH:/home/qishen/ddlog/bin

# For compiled ddlog binary
# export DDLOG_HOME=/home/qishen/.local/bin/ddlog

# For ddlog compiled from source
export DDLOG_HOME=/home/qishen/differential-datalog

# Create runtime for socialnetwork domain
ddlog -i snq1.dl && 
# Open the folder and build the runtime in Rust
(cd snq1_ddlog && cargo build --release) #&& 
# Run the program that depends on the runtime as a library with model as its parameter. 
#(cd snq1_lib && cargo test --release -- it_works /home/qishen/ttc2018liveContest/models/512/ --nocapture)
