import mysql.connector

from ffrkx.proto import messages_pb2
from ffrkx.util import log
from ffrkx.db_server.resources import Cursor, Transaction

class Database:
    def __init__(self, user, password, host, database):
        try:
            self.DBCONN = mysql.connector.connect(user=user, password=password,
                                                  host=host, database=database)
        except err:
            log.log_exception("Unable to connect to MySQL")
            self.DBCONN = None
        pass

    def fetch_all_battles(self):
        if not self.DBCONN:
            return []

        cursor = self.DBCONN.cursor()
        with Cursor(cursor):
            cursor.execute("SELECT id, name FROM battles")
            return [x for x in cursor]

    def fetch_all_items(self):
        if not self.DBCONN:
            return []
        cursor = self.DBCONN.cursor()
        with Cursor(cursor):
            cursor.execute("SELECT id, name FROM items")
            return [x for x in cursor]

    def record_battle_encounter(self, message):
        if not self.DBCONN:
            return

        with Transaction(self.DBCONN):
            log.log_message("Recording battle encounter for battle {0} ({1} items)".format(message.battle_id, len(message.drop_list)))
            cursor = self.DBCONN.cursor()
            with Cursor(cursor):
                cursor.callproc("record_battle_encounter", (message.battle_id,))
                for drop_event in message.drop_list:
                    cursor.callproc("record_drop_event", (message.battle_id, drop_event.item_id, drop_event.count))
                log.log_message("Successfully commited battle encounter")

    def record_dungeon_entry(self, message):
        pass

    def handle_message(self, message):
        if message.HasField("battle_encounter"):
            self.record_battle_encounter(message.battle_encounter)
        if message.HasField("dungeon_entry"):
            self.record_dungeon_entry(message.dungeon_entry)
        pass