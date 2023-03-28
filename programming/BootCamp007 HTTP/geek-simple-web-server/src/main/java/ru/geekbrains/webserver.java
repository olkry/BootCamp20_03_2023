package ru.geekbrains;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.nio.charset.StandardCharsets;

public class webserver {

    public static void main(String[] args) {
        try (ServerSocket serverSocket = new ServerSocket(8088))  {
            Socket socket = serverSocket.accept();
            System.out.println("New line connected!");

            BufferedReader input = new BufferedReader
                    (new InputStreamReader(
                            socket.getInputStream(), StandardCharsets.UTF_8));

            PrintWriter output = new PrintWriter(socket.getOutputStream());

            while (!input.ready());

            while (input.ready()){
                System.out.println(input.readLine());
            }


            output.println("HTTP 1.1 200 OK");
            output.println("Content-Type: text/html; charset-utf-8");
            output.println();
            output.println("Привет от сервера");
            output.flush();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
