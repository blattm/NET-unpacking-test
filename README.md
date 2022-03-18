# Reflection Test
Benign .NET binaries with reflective loading. Can be used to test an unpacker's performance.

## How to generate the binary
1. Build the `hello_world` project.
2. Execute the `insert_bytes.sh` script inside the `loader` folder. (Ensure that the `source_path` variable points to the hello world executable)
3. Build the `loader` project.

Now the loader binary can be used to test an unpackers capabilty.
