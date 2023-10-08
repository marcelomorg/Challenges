package edu.marcelomorg.main.models;

import edu.marcelomorg.main.interfaces.IInternetBrowser;
import edu.marcelomorg.main.interfaces.IMusicPlayer;
import edu.marcelomorg.main.interfaces.IPhone;

public class SmartPhone implements IMusicPlayer, IPhone, IInternetBrowser {
    public SmartPhone(String mark, String model) {
        this.mark = mark;
        this.model = model;
    }
    
    private String mark;
    private String model;

    @Override
    public void showPage() {
        System.out.println("Opening the page in your browser.");
        try {
            for(int i = 3; i > 0; i--){
                System.out.printf("%d...",i);
                Thread.sleep(1000);
            }
        } catch (Exception ex) {
            System.err.println(ex.getMessage());
        }
        System.out.println("\nOpen page.\n");
        
    }

    @Override
    public void addTab() {
        System.out.println("Opening new tab.");
        try {
            for(int i = 3; i > 0; i--){
                System.out.printf("%d...",i);
                Thread.sleep(1000);
            }
        } catch (Exception ex) {
            System.err.println(ex.getMessage());
        }
        System.out.println("\nOpen new tab.\n");

        
    }

    @Override
    public void refreshPage() {
        System.out.println("Updating page.");
        try {

            for(int i = 3; i > 0; i--){
                System.out.printf("%d...",i);
                Thread.sleep(1000);
            }
        } catch (Exception ex) {
            System.err.println(ex.getMessage());
        }
        System.out.println("\nUpdated page.\n");

        
    }

    @Override
    public void call() {
        System.out.println("Making connection.");
        try {

            for(int i = 3; i > 0; i--){
                System.out.printf("%d...",i);
                Thread.sleep(1000);
            }
        } catch (Exception ex) {
            System.err.println(ex.getMessage());
        }
        System.out.println("\nCall made.\n");        
    }

    @Override
    public void listen() {
        System.out.println("Answering call.");
        try {

            for(int i = 3; i > 0; i--){
                System.out.printf("%d...",i);
                Thread.sleep(1000);
            }
        }catch (Exception ex){
            System.err.println(ex.getMessage());
        }
        System.out.println("\nAnswered call.\n");

    }

    @Override
    public void voiceMain() {
        System.out.println("Checking voice mail.");
        try {

            for(int i = 3; i > 0; i--){
                System.out.printf("%d...",i);
                Thread.sleep(1000);
            }
        }catch (Exception ex){
            System.err.println(ex.getMessage());
        }
        System.out.println("\nChecked voice mail.\n");
    }

    @Override
    public void play() {
        System.out.println("Opening music.");
        try {

            for(int i = 3; i > 0; i--){
                System.out.printf("%d...",i);
                Thread.sleep(1000);
            }
        }catch (Exception ex){
            System.err.println(ex.getMessage());
        }
        System.out.println("\nPlayning music.\n");
        
    }

    @Override
    public void pause() {
        System.out.println("Pausing music.");
        try {

            for(int i = 3; i > 0; i--){
                System.out.printf("%d...",i);
                Thread.sleep(1000);
            }
        }catch (Exception ex){
            System.err.println(ex.getMessage());
        }
        System.out.println("\nMusic paused.\n");        
    }

    @Override
    public void musicSelect() {
        System.out.println("Selecting music.");
        try {

            for (int i = 3; i > 0; i--) {
                System.out.printf("%d...", i);
                Thread.sleep(1000);
            }
        } catch (Exception ex) {
            System.err.println(ex.getMessage());
        }
        System.out.println("\nSelected music.\n");
    }
    
    public void whois() {
        System.out.println("\n\n\n----- SmartPhone Information -----" +
            "\nMARK: " + this.mark +
            "\nMODEL: " + this.model +
            "\nIMEI: " + this.mark.hashCode() + this.model.hashCode() + "\n"
        );
    }
    
    public void allFunctions() {
        this.whois();
        this.play();
        this.pause();
        this.musicSelect();
        this.call();
        this.listen();
        this.voiceMain();
        this.showPage();
        this.addTab();
        this.refreshPage();
    }
}
